namespace EndlessRunnerServer
{
    public class Player
    {
        public string PlayerId {get;}
        public string PlayerName {get;}
      
        public Player(string userId, string userName)
        {
            this.PlayerId = userId;
            this.PlayerName = userName;
        }
    }
}