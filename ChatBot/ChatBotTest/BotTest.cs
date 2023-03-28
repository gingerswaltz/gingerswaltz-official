using ChatBotFunc;

namespace ChatBotTest
{
    [TestClass]
    public class BotTest
    {
        [TestMethod]
        public void CheckRegexDigit_ShouldReturnSum()
        {
            var input = "1+2+3";
            var expected = $"{chatFunc.bot} at {DateTime.Now}:Сумма: {6}";
            var result = chatFunc.CheckRegexDigit(input);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CheckRegexDigit_ShouldReturnMinus()
        {
            // Arrange
            var input = "10-2-3";
            var expected = $"{chatFunc.bot} at {DateTime.Now}:Разность:{5}";
            
            // Act
            var result = chatFunc.CheckRegexDigit(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckRegexDigit_ShouldReturnMult()
        {
            // Arrange
            var input = "2*3*4";
            var expected = $"{chatFunc.bot} at {DateTime.Now}:Умножение:{24}";

            // Act
            var result = chatFunc.CheckRegexDigit(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// варианты с кучей пробелов 
        //   [TestMethod]

        //  }
    }
}