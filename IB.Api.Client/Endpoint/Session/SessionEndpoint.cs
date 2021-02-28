using IB.Api.Client.Endpoint.Session.Response;

namespace IB.Api.Client.Endpoint.Session
{
    public class SessionEndpoint : BaseEndpoint
    {
        public SessionValidateResponse ValidateSession()
        {
            return GetApiResponse<SessionValidateResponse>("/sso/validate");
        }
        public SessionStatusResponse SessionStatus()
        {
            return GetApiResponse<SessionStatusResponse>("/iserver/auth/status");
        }
        public SessionReauthenticateResponse ReauthenticateSession()
        {
            return PostApiResponse<SessionReauthenticateResponse>("/iserver/reauthenticate");
        }
        public SessionTickleResponse TickleSession()
        {
            return GetApiResponse<SessionTickleResponse>("/tickle");
        }
    }
}
