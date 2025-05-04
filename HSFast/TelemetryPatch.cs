using System.Collections.Generic;
using Blizzard.Telemetry;
using Blizzard.Telemetry.Standard.Network;
using Blizzard.Telemetry.WTCG.Client;
using HearthstoneTelemetry;
using Google.Protobuf;
using MessageOptions = Google.Protobuf.Reflection.MessageOptions;

namespace HSFast
{
    public class TelemetryPatch : ITelemetryClient
    {
        public void SendACSdkResult(string reportId, ACSdkResult.CommandType commandType_, string scriptId, bool returnSetExtraParams,
            int returnSetupSDK, int returnCallSDK, List<string> messages)
        {
            
        }

        public void SendAppInitialized(string testType, float duration, string clientChangelist)
        {
            
        }

        public void SendAppPaused(bool pauseStatus, float pauseTime)
        {
            
        }

        public void SendAppStart(string testType, float duration, string clientChangelist)
        {
            
        }

        public void SendAssetLoaderError(string assetGuid, string bundleName, AssetLoaderError.AssetBundleErrorReason reason, string detail)
        {
            
        }

        public void SendAssetNotFound(string assetType, string assetGuid, string filePath, string legacyName)
        {
            
        }

        public void SendAttackInputMethod(long totalNumAttacks, long totalClickAttacks, int percentClickAttacks, long totalDragAttacks,
            int percentDragAttacks)
        {
            
        }

        public void SendBattlegroundsCollectionResult(BattlegroundsCollectionResult.TriggerEvent triggerEvent_, int numberOfOwnedHeroSkins,
            List<int> favoriteBaseHeroCardIds, List<int> favoriteHeroSkinIds, int numberOfOwnedStrikes, List<int> favoriteStrikeIds,
            int numberOfOwnedBartenders, List<int> favoriteBartenderSkinIds, int numberOfOwnedBoardSkins, List<int> favoriteBoardSkinIds,
            int numberOfOwnedEmotes, List<int> equippedEmoteIds)
        {
            
        }

        public void SendBenchmarkResult(int cpuAverageFrameTimeMs, int gpuAverageFrameTimeMs, int benchmarkVersion)
        {
            
        }

        public void SendBGDownloadResult(float duration, long prevRemainingBytes, long downloadedBytes)
        {
            
        }

        public void SendBlizzardCheckoutInitializationResult(bool success, string failureReason, string failureDetails)
        {
            
        }

        public void SendBlizzardCheckoutIsReady(double secondsShown, bool isReady)
        {
            
        }

        public void SendBlizzardCheckoutPurchaseCancel()
        {
            
        }

        public void SendBlizzardCheckoutPurchaseCompletedFailure(string transactionId, string productId, string currency,
            List<string> errorCodes)
        {
            
        }

        public void SendBlizzardCheckoutPurchaseCompletedSuccess(string transactionId, string productId, string currency)
        {
            
        }

        public void SendBlizzardCheckoutPurchaseStart(string transactionId, string productId, string currency)
        {
            
        }

        public void SendBoardVisualStateChanged(string fromBoardState, string toBoardState, int timeInSeconds)
        {
            
        }

        public void SendBoxInteractable(string testType, float duration, string clientChangelist, int dataVersion)
        {
            
        }

        public void SendBoxProductBannerClicked(string bannerCampaignName, string bannerImageName, long productId)
        {
            
        }

        public void SendBoxProductBannerDisplayed(string bannerCampaignName, string bannerImageName, long productId)
        {
            
        }

        public void SendButtonPressed(string buttonName)
        {
            
        }

        public void SendCinematic(bool begin, float duration)
        {
            
        }

        public void SendClearInactiveLocales(List<string> locales, bool success, string errors)
        {
            
        }

        public void SendClickRecruitAFriend()
        {
            
        }

        public void SendClientReset(bool forceLogin, bool forceNoAccountTutorial)
        {
            
        }

        public void SendCollectionLeftRightClick(CollectionLeftRightClick.Target target_)
        {
            
        }

        public void SendContentConnectFailedToConnect(string url, int httpErrorcode, int serverErrorcode)
        {
            
        }

        public void SendContentConnectJsonOpFailed(ContentConnectJsonOpFailed.JsonOp op, string filename, string reason)
        {
            
        }

        public void SendCosmeticsRenderingFallback(string eventMessage)
        {
            
        }

        public void SendDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes, int errorCode)
        {
            
        }

        public void SendDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendDataUpdateProgress(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendDataUpdateStarted()
        {
            
        }

        public void SendDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes, bool byUser)
        {
            
        }

        public void SendDeckCopied(long deckId, string deckHash)
        {
            
        }

        public void SendDeckPickerToCollection(DeckPickerToCollection.Path path_)
        {
            
        }

        public void SendDeckUpdateResponseInfo(float duration)
        {
            
        }

        public void SendDeepLinkExecuted(string deepLink, string source, bool completed, int questId)
        {
            
        }

        public void SendDeletedInvalidBundles(List<string> bundles, int counts)
        {
            
        }

        public void SendDeleteModuleData(string moduleName, long deletedSize)
        {
            
        }

        public void SendDeleteOptionalData(long deletedSize)
        {
            
        }

        public void SendDeviceMuteChanged(bool muted)
        {
            
        }

        public void SendDeviceVolumeChanged(float oldVolume, float newVolume)
        {
            
        }

        public void SendDragDropCancelPlayCard(long scenarioId, string cardType)
        {
            
        }

        public void SendEndGameScreenInit(float elapsedTime, int medalInfoRetryCount, bool medalInfoRetriesTimedOut,
            bool showRankedReward, bool showCardBackProgress, int otherRewardCount)
        {
            
        }

        public void SendExternalAccountLinkingState(ExternalAccountLinkingState.Status state, ulong externalAccountId)
        {
            
        }

        public void SendFatalBattleNetError(int errorCode, string description)
        {
            
        }

        public void SendFatalError(string reason, int dataVersion)
        {
            
        }

        public void SendFlowPerformance(string uniqueId, Blizzard.Telemetry.WTCG.Client.FlowPerformance.FlowType flowType_, float averageFps, float duration,
            float fpsWarningsThreshold, int fpsWarningsTotalOccurences, float fpsWarningsTotalTime,
            float fpsWarningsAverageTime, float fpsWarningsMaxTime)
        {
            
        }

        public void SendFlowPerformanceBattlegrounds(string flowId, string gameUuid, int totalRounds)
        {
            
        }

        public void SendFlowPerformanceGame(string flowId, string uuid, GameType gameType, FormatType formatType, int boardId,
            int scenarioId)
        {
            
        }

        public void SendFlowPerformanceShop(string flowId, Blizzard.Telemetry.WTCG.Client.FlowPerformanceShop.ShopType shopType_)
        {
            
        }

        public void SendFriendsListView(string currentScene)
        {
            
        }

        public void SendFTUEButtonClicked(string gameMode)
        {
            
        }

        public void SendFTUELetsGoButtonClicked(string gameMode)
        {
            
        }

        public void SendFTUEVideoTimeout(string gameMode)
        {
            
        }

        public void SendGameRoundStartAudioSettings(bool deviceMuted, float deviceVolume, float masterVolume, float musicVolume)
        {
            
        }

        public void SendIgnorableBattleNetError(int errorCode, string description)
        {
            
        }

        public void SendIKSClicked(string iksCampaignName, string iksMediaUrl)
        {
            
        }

        public void SendIKSIgnored(string iksCampaignName, string iksMediaUrl)
        {
            
        }

        public void SendInGameMessageAction(string messageType, string title, InGameMessageAction.ActionType action, int viewCounts, string uid)
        {
            
        }

        public void SendInGameMessageDataError(string messageType, string title, InGameMessageDataError.ErrorType error, string uid)
        {
            
        }

        public void SendInGameMessageDelayedMessages(string messageType, string eventId)
        {
            
        }

        public void SendInGameMessageDisplayed(string messageType, string uid, string title)
        {
            
        }

        public void SendInGameMessageQualified(string messageType, List<string> uids)
        {
            
        }

        public void SendInGameMessageSystemFlow(string messageType, string eventId, int count,
            InGameMessageSystemFlow.TelemetryMessageType telemetryMessageType_, string uid)
        {
            
        }

        public void SendInitialClientStateOutOfOrder(int countNotificationsAchieve, int countNotificationsNotice,
            int countNotificationsCollection, int countNotificationsCurrency, int countNotificationsBooster,
            int countNotificationsHeroxp, int countNotificationsPlayerRecord, int countNotificationsArenaSession,
            int countNotificationsCardBack)
        {
            
        }

        public void SendInitialDataRequested(string version, int dataVersion)
        {
            
        }

        public void SendInitTraceroute(bool success, string initStatus)
        {
            
        }

        public void SendJobFinishFailure(string jobId, string jobFailureReason, string testType, string clientChangelist,
            float duration)
        {
            
        }

        public void SendLanguageChanged(string previousLanguage, string nextLanguage)
        {
            
        }

        public void SendLiveIssue(string category, string details)
        {
            
        }

        public void SendLoadProducts(float timeToLoadProducts, float timeToDeserialize)
        {
            
        }

        public void SendLocaleDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes, int errorCode)
        {
            
        }

        public void SendLocaleDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendLocaleDataUpdateStarted(string locale)
        {
            
        }

        public void SendLocaleDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes, bool byUser)
        {
            
        }

        public void SendLocaleModuleDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes, int errorCode,
            string moduleName)
        {
            
        }

        public void SendLocaleModuleDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes,
            string moduleName)
        {
            
        }

        public void SendLocaleModuleDataUpdateStarted(string locale, string moduleName)
        {
            
        }

        public void SendLocaleModuleDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes, bool byUser,
            string moduleName)
        {
            
        }

        public void SendLocaleOptionalDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes,
            int errorCode)
        {
            
        }

        public void SendLocaleOptionalDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendLocaleOptionalDataUpdateStarted(string locale)
        {
            
        }

        public void SendLocaleOptionalDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes,
            bool byUser)
        {
            
        }

        public void SendLoginTokenFetchResult(LoginTokenFetchResult.TokenFetchResult result)
        {
            
        }

        public void SendLuckyDrawEventMessage(string eventMessage)
        {
            
        }

        public void SendManaFilterToggleOff()
        {
            
        }

        public void SendMASDKAuthResult(MASDKAuthResult.AuthResult result, int errorCode, string source)
        {
            
        }

        public void SendMASDKImportResult(MASDKImportResult.ImportResult result, MASDKImportResult.ImportType importType_, int errorCode)
        {
            
        }

        public void SendMasterVolumeChanged(float oldVolume, float newVolume)
        {
            
        }

        public void SendMercenariesVillageBuildingClicked(int buildingId)
        {
            
        }

        public void SendMercenariesVillageEnter()
        {
            
        }

        public void SendMercenariesVillageExit()
        {
            
        }

        public void SendMinSpecWarning(bool nextVersion, List<string> warnings)
        {
            
        }

        public void SendMobileFailConnectGameServer(string address, bool moreinfoPressed, bool gotitPressed)
        {
            
        }

        public void SendModuleDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes, int errorCode,
            string moduleName)
        {
            
        }

        public void SendModuleDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes,
            string moduleName)
        {
            
        }

        public void SendModuleDataUpdateStarted(string moduleName)
        {
            
        }

        public void SendModuleDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes, bool byUser,
            string moduleName)
        {
            
        }

        public void SendMusicVolumeChanged(float oldVolume, float newVolume)
        {
            
        }

        public void SendNDERerollPopupClicked(bool acceptedReroll, List<long> noticeIds, int cardAsset, List<int> cardPremium, int cardQuantity,
            int ndePremium, bool isForcedPremium)
        {
            
        }

        public void SendNetworkError(NetworkError.ErrorType errorType_, string description, int errorCode)
        {
            
        }

        public void SendNetworkUnreachableRecovered(int outageSeconds)
        {
            
        }

        public void SendOldVersionInStore(string liveVersion, string updatestat, bool silentGo)
        {
            
        }

        public void SendOptionalDataUpdateFailed(float duration, long realDownloadBytes, long expectedDownloadBytes, int errorCode)
        {
            
        }

        public void SendOptionalDataUpdateFinished(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendOptionalDataUpdateStarted()
        {
            
        }

        public void SendOptionalDataUpdateStopped(float duration, long realDownloadBytes, long expectedDownloadBytes, bool byUser)
        {
            
        }

        public void SendPackOpening(float timeToRegisterPackOpening, float timeTillAnimationStart, int packTypeId, int packsOpened)
        {
            
        }

        public void SendPackOpenToStore(PackOpenToStore.Path path_)
        {
            
        }

        public void SendPersonalizedMessagesResult(bool success, int messageCount, List<string> messageUids)
        {
            
        }

        public void SendPresenceChanged(PresenceStatus newPresenceStatus, PresenceStatus prevPresenceStatus,
            long millisecondsSincePrev)
        {
            
        }

        public void SendPreviousInstanceStatus(int totalCrashCount, int totalExceptionCount, int lowMemoryWarningCount,
            int crashInARowCount, int sameExceptionCount, bool crashed, string exceptionHash)
        {
            
        }

        public void SendPurchaseCancelClicked(long pmtProductId)
        {
            
        }

        public void SendPurchasePayNowClicked(long pmtProductId)
        {
            
        }

        public void SendPushNotificationSystemAppInitialized(string appName, string userId)
        {
            
        }

        public void SendPushNotificationSystemDeviceTokenObtained(string appName, string userId, string deviceToken)
        {
            
        }

        public void SendPushNotificationSystemNotificationDeleted(string appName, string userId)
        {
            
        }

        public void SendPushNotificationSystemNotificationOpened(string appName, string userId)
        {
            
        }

        public void SendPushNotificationSystemNotificationReceived(string appName, string userId)
        {
            
        }

        public void SendPushRegistrationFailed(string error)
        {
            
        }

        public void SendPushRegistrationSucceeded(string deviceToken)
        {
            
        }

        public void SendQuestTileClick(int questID, DisplayContext displayContext, QuestTileClickType clickType, string deepLinkValue)
        {
            
        }

        public void SendReconnectSuccess(float disconnectDuration, float reconnectDuration, string reconnectType)
        {
            
        }

        public void SendReconnectTimeout(string reconnectType)
        {
            
        }

        public void SendRegionSwitched(int currentRegion, int newRegion)
        {
            
        }

        public void SendRestartDueToPlayerMigration()
        {
            
        }

        public void SendRuntimeUpdate(float duration, RuntimeUpdate.Intention intention_)
        {
            
        }

        public void SendSeamlessReconnectEnd(float disconnectDuration, string disconnectReason, int secSinceLastResume,
            int secSpentPaused)
        {
            
        }

        public void SendSeamlessReconnectStart(string disconnectReason, int secSinceLastResume, int secSpentPaused)
        {
            
        }

        public void SendShopBalanceAvailable(List<Balance> balances)
        {
            
        }

        public void SendShopCardClick(ShopCard shopcard, string storeType, string shopTab, string shopSubTab)
        {
            
        }

        public void SendShopProductDetailOpened(long productId, float loadingTime)
        {
            
        }

        public void SendShopPurchaseEvent(Product product, int quantity, string currency, double amount, bool isGift,
            string storefront, bool purchaseComplete, string storeType, string redirectedProductId, string shopTab,
            string shopSubTab)
        {
            
        }

        public void SendShopStatus(string error, double timeInHubSec, float timeShownClosedSec)
        {
            
        }

        public void SendShopVisit(List<ShopCard> cards, string storeType, string shopTab, string shopSubTab, float loadTimeSeconds)
        {
            
        }

        public void SendSmartDeckCompleteFailed(int requestMessageSize)
        {
            
        }

        public void SendStartupAudioSettings(bool deviceMuted, float deviceVolume, float masterVolume, float musicVolume)
        {
            
        }

        public void SendSystemDetail(UnitySystemInfo info)
        {
            
        }

        public void SendTraceroute(string host, List<string> hops, int totalHops, int failHops, int successHops)
        {
            
        }

        public void SendWebLoginError()
        {
            
        }

        public void SendWelcomeQuestsAcknowledged(float questAckDuration)
        {
            
        }

        public void SendWrongVersionContinued(string liveVersion, string updatestat)
        {
            
        }

        public void SendWrongVersionFixed(string liveVersion, int reties, bool succeeded)
        {
            
        }

        public void SendApkInstallFailure(string updatedVersion, string reason)
        {
            
        }

        public void SendApkInstallSuccess(string updatedVersion, float availableSpaceMB, float elapsedSeconds)
        {
            
        }

        public void SendApkUpdate(int installedVersion, int assetVersion, int agentVersion)
        {
            
        }

        public void SendNotEnoughSpaceError(ulong availableSpace, ulong expectedOrgBytes, string filesDir, bool initial,
            bool localeSwitch)
        {
            
        }

        public void SendNoWifi(string updatedVersion, float availableSpaceMB, float elapsedSeconds, bool initial, bool localeSwitch)
        {
            
        }

        public void SendOpeningAppStore(string updatedVersion, float availableSpaceMB, float elapsedSeconds, string versionInStore)
        {
            
        }

        public void SendUpdateError(uint errorCode, float elapsedSeconds)
        {
            
        }

        public void SendUpdateFinished(string updatedVersion, float availableSpaceMB, float elapsedSeconds)
        {
            
        }

        public void SendUpdateProgress(float duration, long realDownloadBytes, long expectedDownloadBytes)
        {
            
        }

        public void SendUpdateStarted(string installedVersion, string textureFormat, string dataPath, float availableSpaceMB)
        {
            
        }

        public void SendUpdateStopped(string updatedVersion, float availableSpaceMB, float elapsedSeconds, bool byUser)
        {
            
        }

        public void SendUsingCellularData(string updatedVersion, float availableSpaceMB, float elapsedSeconds, bool initial,
            bool localeSwitch)
        {
            
        }

        public void SendVersionCodeInStore(string versionCode, string countryCode)
        {
            
        }

        public void SendVersionError(uint errorCode, uint agentState, string languages, string region, string branch,
            string additionalTags)
        {
            
        }

        public void SendVersionFinished(string currentVersion, string liveVersion)
        {
            
        }

        public void SendVersionStarted(int dummy)
        {
            
        }

        public bool IsInitialized()
        {
            return true;
        }

        public void Enable()
        {
            
        }

        public void Disable()
        {
            
        }

        public void OnUpdate()
        {
            
        }

        public void Shutdown()
        {
            
        }

        public long EnqueueMessage(IProtoBuf message, Blizzard.Telemetry.MessageOptions options = null)
        {
            return -1;
        }

        public long EnqueueMessage(string packageName, string messageName, byte[] data, Blizzard.Telemetry.MessageOptions options = null)
        {
            return -1;
        }

        public void SendConnectSuccess(string name, string host = null, uint? port = null)
        {
            
        }

        public void SendConnectFail(string name, string reason, string host = null, uint? port = null)
        {
            
        }

        public void SendDisconnect(string name, Disconnect.Reason reason, string description = null, string host = null, uint? port = null)
        {
             
        }

        public void SendFindGameResult(FindGameResult message)
        {
            
        }

        public void SendConnectToGameServer(ConnectToGameServer message)
        {
            
        }

        public void SendTcpQualitySample(string address4, uint port, float sampleTimeMs, uint bytesSent, uint bytesReceived,
            uint messagesSent, uint messagesReceived, TcpQualitySample.Metric timeSincePrevMessageMs, TcpQualitySample.Metric pingMs)
        {
            
        }

        public void SendDisconnect(string name, Network.GameCancelInfo.Reason reason, string description = null, string host = null, uint? port = null)
        {
            
        }

        public long EnqueueMessage(string packageName, string messageName, byte[] data, MessageOptions options)
        {
            return -1;
        }

        public long EnqueueMessage(IProtoBuf message, MessageOptions options)
        {
            return -1;
        }

        public void Initialize(Service telemetryService)
        {
            
        }
    }
}