namespace BlackJack
{
    public class Game
    {
        private Deck _deck = new Deck();
        public Player Player1 {get; }= new Player();

        
        public void ShuffleDeck()
        {
            _deck.Shuffle();
        }

        public void DealFirstHandToPlayer(Player player)
        {
            player.Hand.AddCard(_deck.Draw());
            player.Hand.AddCard(_deck.Draw());
        }
    }
}