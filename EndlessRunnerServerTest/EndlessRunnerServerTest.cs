using NUnit.Framework;

namespace EndlessRunnerServerTest
{
    
    public class EndlessRunnerServerTest
    {

        [Test]
        public void PassingTest()
        {
            var endlessRunnerServer = new EndlessRunnerServer.EndlessRunnerServer();
            var playersResponse = endlessRunnerServer.GetAllRegisteredPlayerNames();
            Assert.IsNotEmpty(playersResponse.Players);
            Assert.AreEqual(1, playersResponse.Players.Count);
        }
    }
}