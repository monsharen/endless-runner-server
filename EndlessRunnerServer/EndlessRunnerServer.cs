using System.Collections.Generic;
using CloudCode.Authoring;
using CloudCode.Authoring.Modules;

namespace EndlessRunnerServer
{
    public class EndlessRunnerServer
    {
        [CloudCodeFunction("HelloWorld")]
        public string HelloWorld()
        {
            return "Hello world!";
        }


        [CloudCodeFunction("GetAllRegisteredPlayerNames")]
        public PlayersResponse GetAllRegisteredPlayerNames()
        {
            Player player = new Player("7Drt6215vXXFFZPXFQPZvAPlgvq5", "monsharen");
            List<Player> playersList = new List<Player>();
            playersList.Add(player);
            
            return new PlayersResponse(playersList);
        }

        public class PlayersResponse
        {
            public List<Player> Players { get; set;}
          
            public PlayersResponse(List<Player> players) {
                Players = players;
            }
        }
    }
}