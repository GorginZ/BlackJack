namespace BlackJack
{
    public class Game
    {
        private Deck _deck = new Deck();
        private Player _player1 = new Player();

        
        public void ShuffleDeck()
        {
            _deck.Shuffle();
        }
    }
}