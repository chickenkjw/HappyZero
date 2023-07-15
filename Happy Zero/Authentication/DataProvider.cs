using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Inhu.Authentication {
	public class DataProvider {
		private readonly ProtectedSessionStorage _sessionStorage;

		public DataProvider(ProtectedSessionStorage sessionStorage) {
			_sessionStorage = sessionStorage;
		}

		public async Task SetUserData(UserSession session) {
			await _sessionStorage.SetAsync("UserSession", session);

			return;
		}

		public async Task<UserSession> GetUserSession() {
			var userSessionStateResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
			var userSession = userSessionStateResult.Success ? userSessionStateResult.Value : null;

			return userSession;
		}
	}
}