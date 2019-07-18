using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayFabBuddyLib
{
	public class PlayFabClient : IPlayFabClient
	{
		/// <summary>
		/// Constructor!
		/// </summary>
		/// <param name="titleId">The titleId for your PlayFab game.</param>
		public PlayFabClient(string titleId)
		{
			PlayFabSettings.TitleId = titleId;
		}

		public Task<PlayFabResult<AddUsernamePasswordResult>> AddUsernamePasswordAsync(AddUsernamePasswordRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.AddUsernamePasswordAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LinkCustomIDResult>> LinkCustomIDAsync(LinkCustomIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LinkCustomIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LoginWithAndroidDeviceIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LoginWithCustomIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LoginResult>> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LoginWithEmailAddressAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LoginWithIOSDeviceIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<LoginResult>> LoginWithFacebookAsync(LoginWithFacebookRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.LoginWithFacebookAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UnlinkAndroidDeviceIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UnlinkCustomIDResult>> UnlinkCustomIDAsync(UnlinkCustomIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UnlinkCustomIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UnlinkIOSDeviceIDAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.SendAccountRecoveryEmailAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetAccountInfoResult>> GetAccountInfoAsync(GetAccountInfoRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetAccountInfoAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UpdateUserTitleDisplayNameAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetUserInventoryAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.AddUserVirtualCurrencyAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<PurchaseItemResult>> PurchaseItemAsync(PurchaseItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.PurchaseItemAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.ConsumeItemAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetUserDataAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetUserPublisherDataAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetPlayerStatisticsAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UpdateUserDataAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UpdateUserPublisherDataAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetLeaderboardAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.UpdatePlayerStatisticsAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetFriendLeaderboardAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetLeaderboardAroundPlayerResult>> GetLeaderboardAroundPlayerAsync(GetLeaderboardAroundPlayerRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetLeaderboardAroundPlayerAsync(request, customData, extraHeaders);
		}

		public Task<PlayFabResult<GetFriendLeaderboardAroundPlayerResult>> GetFriendLeaderboardAroundPlayerAsync(GetFriendLeaderboardAroundPlayerRequest request, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
			return PlayFabClientAPI.GetFriendLeaderboardAroundPlayerAsync(request, customData, extraHeaders);
		}
	}
}
