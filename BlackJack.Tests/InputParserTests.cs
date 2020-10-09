using Xunit;
namespace BlackJack.Tests

{
    public class InputParserTests
    {
        [Fact]
        public void _0_returnsStay()
        {
    
            const NextAction expectedNextAction = NextAction.Stay;

            var isValid = InputParser.TryParse("0", out var actualNextAction);

            Assert.True(isValid);
            Assert.Equal(expectedNextAction, actualNextAction);

        }

        [Fact]
        public void _1_returnsHit()
        {
    
            const NextAction expectedNextAction = NextAction.Hit;

            var isValid = InputParser.TryParse("1", out var actualNextAction);

            Assert.True(isValid);
            Assert.Equal(expectedNextAction, actualNextAction);

        }

        [Fact]
        public void unknownInput_returnsInvalid()
        {
    
            const NextAction expectedNextAction = NextAction.Invalid;

            var isValid = InputParser.TryParse("???", out var actualNextAction);

            Assert.False(isValid);
            Assert.Equal(expectedNextAction, actualNextAction);

        }
    }
}