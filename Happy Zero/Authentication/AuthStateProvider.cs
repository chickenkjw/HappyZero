using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace Inhu.Authentication {
	public class AuthStateProvider : AuthenticationStateProvider {
		private readonly ProtectedSessionStorage _sessionStorage;
		private readonly ClaimsPrincipal _anonymous = new(new ClaimsIdentity());

		public AuthStateProvider(ProtectedSessionStorage sessionStorage) {
			_sessionStorage = sessionStorage;
		}

		public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
			try {
				var userSessionStateResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
				var userSession = userSessionStateResult.Success ? userSessionStateResult.Value : null;

				if(userSession == null) {
					return await Task.FromResult(new AuthenticationState(_anonymous));
				}

				var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim> {
					new(ClaimTypes.Name, userSession.Name),
					new(ClaimTypes.Role, userSession.Role),
					new(ClaimTypes.Email, userSession.Email),
					new(ClaimTypes.NameIdentifier, userSession.Uid),
				}, "AuthenticationType"));

				return await Task.FromResult(new AuthenticationState(claimsPrincipal));
			}
			catch {
				return await Task.FromResult(new AuthenticationState(_anonymous));
			}
		}

		public async Task UpdateAuthenticaitonState(UserSession? userSession) {
			ClaimsPrincipal claimsPrincipal;

			if(userSession != null) {
				await _sessionStorage.SetAsync("UserSession", userSession);
				claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim> {
					new(ClaimTypes.Name,userSession.Name),
					new(ClaimTypes.Role, userSession.Role),
					new(ClaimTypes.Email, userSession.Email),
					new(ClaimTypes.NameIdentifier, userSession.Uid),
				}, "AuthenticationType"));
			}
			else {
				await _sessionStorage.DeleteAsync("UserSession");
				//await _sessionStorage.DeleteAsync("UserData");
				claimsPrincipal = _anonymous;
			}

			NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
		}
	}
}