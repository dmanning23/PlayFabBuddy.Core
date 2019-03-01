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
	}
}
