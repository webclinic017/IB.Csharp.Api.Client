using IB.Api.Client.Endpoint.Session;
using NUnit.Framework;

namespace IB.Api.Client.Test
{
    [TestFixture]
    public class SessionTests
    {
        SessionEndpoint sessionEndpoint;

        [SetUp]
        public void Setup()
        {
            sessionEndpoint = new SessionEndpoint();
        }

        [Test]
        public void ValidateSession()
        {
            var response = sessionEndpoint.ValidateSession();
            Assert.IsTrue(response.Result);
        }
    }
}
