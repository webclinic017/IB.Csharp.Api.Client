using IB.Api.Client.Endpoint.Session.Response;

namespace IB.Api.Client.Endpoint.Session
{
    public class SessionEndpoint : BaseEndpoint
    {
        public ValidateSessionResponse ValidateSession()
        {
            return GetApiResponse<ValidateSessionResponse>("/sso/validate");
        }
        public SessionStatusResponse SessionStatus()
        {
            return GetApiResponse<SessionStatusResponse>("/iserver/auth/status");
        }
        public ReauthenticateSessionResponse ReauthenticateSession()
        {
            return PostApiResponse<ReauthenticateSessionResponse>("/iserver/reauthenticate");
        }
        public TickleSessionResponse TickleSession()
        {
            return GetApiResponse<TickleSessionResponse>("/tickle");
        }
    }
}
