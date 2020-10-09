namespace BlackJack
{
    public static class InputParser
    {
        public static bool TryParse(string input, out NextAction nextAction)
        {
            if(input == "0")
            {
                nextAction = NextAction.Stay;
                return true;
            } else if (input == "1")
            {
                nextAction = NextAction.Hit;
                return true;
            }

            nextAction = NextAction.Invalid;
            return false;
        }
    }
}