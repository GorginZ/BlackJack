using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public static class HandCalculator
    {
        public static int Calculate(List<Card> hand)
        {
            var runningValue = SumNonAces(GetHandWithoutAces(hand));
            runningValue += SumAces(GetAcesFromHand(hand), runningValue);
            return runningValue;
        }

        private static List<Card> GetHandWithoutAces(List<Card> hand)
        {
            return hand.Where(card => card.Rank != Rank.Ace).ToList();
        }

        private static List<Card> GetAcesFromHand(List<Card> hand)
        {
            return hand.Where(card => card.Rank == Rank.Ace).ToList();
        }

        private static int SumNonAces(List<Card> handWithoutAces)
        {
            return handWithoutAces.Aggregate(0, (currentValue, card) => IsFaceCard(card) ? (currentValue + 10) : currentValue + (int)card.Rank);
        }
        private static bool IsFaceCard(Card card)
        {
            return card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King;
        }
        private static int SumAces(List<Card> acesInHand, int valueBeforeAces)
        {
            return acesInHand.Aggregate(0, (currentValue, card) => valueBeforeAces <= 10 ? (currentValue + 11) : (currentValue + 1));
        }
    }
}