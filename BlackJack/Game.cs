namespace BlackJack
{
    public class Game
    {
        private Deck _deck = new Deck();
        public Player Player1 {get; }= new Player();
        public Player Dealer {get; } = new Player();

        public Player ActivePlayer;

        public Game()
        {
            ShuffleDeck();
            DealFirstHandToPlayer(Player1);
            ActivePlayer = Player1;
        }
        private void ShuffleDeck()
        {
            _deck.Shuffle();
        }

        private void DealFirstHandToPlayer(Player player)
        {
            player.Hand.AddCard(_deck.Draw());
            player.Hand.AddCard(_deck.Draw());
        }


    }
}