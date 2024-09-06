using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Blizzard.T5.Core.Time;

namespace HSFast;
public class PluginInfo
{
    public const string PLUGIN_GUID = "com.agitoreiken.hsfast";
    public const string PLUGIN_NAME = "HSFast";
    public const string PLUGIN_VERSION = "1.0.0";
}

public enum TimeScaleEnum
{
    x1, 
    X2,
    X3,
    x6
}
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private ConfigEntry<TimeScaleEnum> TimeScale;
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        TimeScale = Config.Bind("General", "TimeScale", TimeScaleEnum.X2, "Time scale of the game events");
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
         
    }

    private void Update()
    {
        float value = 1.0f;
        switch (TimeScale.Value)
        {
            case TimeScaleEnum.X2:
                value = 2.0f;
                break;
            case TimeScaleEnum.X3:
                value = 3.0f;
                break;
            case TimeScaleEnum.x6:
                value = 6.0f;
                break;
            default:
                break;
        }
        TimeScaleMgr.Get().SetGameTimeScale(value);
    }
}
