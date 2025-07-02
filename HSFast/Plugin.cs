using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using Assets;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Blizzard.GameService.SDK.Client.Integration;
using Blizzard.T5.Core.Time;
using JetBrains.Annotations;
using HarmonyLib;
using Hearthstone;
using Hearthstone.Core.Streaming;
using Hearthstone.LookDev;
using Hearthstone.Streaming;
using HearthstoneTelemetry;
using Networking;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HSFast
{
    [HarmonyPatch(typeof(TimeScaleMgr))]
    public class TimeScaleMgrPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Update")]
        static bool Update()
        {   
            return false;
        }
    }  
    [HarmonyPatch(typeof(TelemetryManager))]
    public class TelemetryManagerPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch("Client")]
        static void Client(ref ITelemetryClient __result)
        {
            Plugin.Logger.LogDebug("TelemetryRequest");
            __result = Plugin.TelemetryClient;
        }
        
    }   
    [HarmonyPatch(typeof(BoardEventListener))]
    public class BoardEventListenerPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("TriggerAnimation")]
        static bool TriggerAnimation(string triggerName)
        {
            return false;
        }
    }
    
    public class PluginInfo
    {
        public const string PLUGIN_GUID = "com.agitoreiken.hsfast";
        public const string PLUGIN_NAME = "HSFast";
        public const string PLUGIN_VERSION = "1.0.0";
    }
    
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin 
    {
        private ConfigEntry<float> CfgTimeScale;
        private ConfigEntry<bool> CfgTriggerReconnect;
        private ConfigEntry<bool> CfgDisableTelemetry;
        public static TelemetryPatch TelemetryClient = new TelemetryPatch();
        public static new ManualLogSource Logger;
        private float Speed;
        private void Awake()
        {
            // Plugin startup logic
            CfgTimeScale = Config.Bind("General", "TimeScale", 2.0f, "Time scale of the game events");
            CfgDisableTelemetry = Config.Bind("General", "DisableTelemetry", false, "Disables gathering data by blizzard");
            CfgTriggerReconnect = Config.Bind("General", "TriggerReconnect", false,
                "Will force reconnect to the game when switched on");
            CfgTriggerReconnect.SettingChanged += TriggerReconnect;   
            
            Logger = base.Logger;
            Harmony.CreateAndPatchAll(typeof(TimeScaleMgrPatch));
            try
            {
                Harmony.CreateAndPatchAll(typeof(TelemetryPatch));
            }
            catch (Exception ex)
            {
                Logger.LogError("Failed to apply TelemetryPatch");
                Logger.LogError(ex.Message);
            }
            Speed = CfgTimeScale.Value;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
     
        private void TriggerReconnect([CanBeNull] object sender, EventArgs e)
        {
            if (CfgTriggerReconnect.Value)
            {
                Logger.LogInfo("Triggering reconnect");
                //GameMgr.Get().RestartGame();
                GameServerInfo gs = Network.Get().GetLastGameServerJoined();
                Network.Get().DisconnectFromGameServer(Network.DisconnectReason.GameState_Reconnect);
                Network.Get().GotoGameServer(gs, true); 
                SceneMgr.Get().ReloadMode();
                CfgTriggerReconnect.Value = false;
            }
        }
       
        private void OnDestroy()
        {
            Logger.LogError("HSFast::OnDestroy called!");
        }

        private void Update()
        {
            Speed = CfgTimeScale.Value;
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Speed = Math.Max(1, Speed - 1);
                CfgTimeScale.Value = Speed;
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                Speed = Math.Min(8, Speed + 1);
                CfgTimeScale.Value = Speed;
            }

            if (Math.Abs(Speed - CfgTimeScale.Value) > 0.01f)
            {
                CfgTimeScale.Value = Speed;
            }
            UnityEngine.Time.timeScale = Speed;
            Cursor.visible = true;
        }
    }
}