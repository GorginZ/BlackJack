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
            var card1 = _deck.Draw();
            var card2 = _deck.Draw();

            player.Hand.AddRange(new Card[] {card1,card2});
        }
    }
}