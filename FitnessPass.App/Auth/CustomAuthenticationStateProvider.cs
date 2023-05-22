using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Data;
using System.Security.Claims;

namespace FitnessPass.App.Auth
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider {

        private readonly ProtectedSessionStorage _sessionStorage;
        public ProtectedSessionStorage SessionStorage {
            get { return _sessionStorage; }
        }

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage, ClaimsPrincipal user) {
            this._sessionStorage = sessionStorage;
        }

        private ClaimsPrincipal GetUser(string id, string email, string role) {
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Sid, id),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            }, "Authentication type");

            return new ClaimsPrincipal(identity);
        }

        private ClaimsPrincipal GetAnonymous() {
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Sid, "0"),
                new Claim(ClaimTypes.Email, "Anonymous"),
                new Claim(ClaimTypes.Role, "Anonymous")
            }, null);

            return new ClaimsPrincipal(identity);
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
            try {
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
                if (userSession == null) {
                    return await Task.FromResult(new AuthenticationState(this.GetAnonymous()));
                }

                var claimsPrincipal = new ClaimsPrincipal(GetUser(userSession.Id.ToString(), userSession.Email, userSession.Role));

                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            } catch {
                return await Task.FromResult(new AuthenticationState(this.GetAnonymous()));
            }
        }

        public async Task UpdateAuthenticationState(UserSession userSession) {
            ClaimsPrincipal claimsPrincipal;

            if (userSession == null) {
                await _sessionStorage.DeleteAsync("UserSession");
                claimsPrincipal = GetAnonymous();
            } else {
                await _sessionStorage.SetAsync("UserSession", userSession);
                claimsPrincipal = this.GetUser(userSession.Id.ToString(), userSession.Email, userSession.Role);
            }

            this.NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
