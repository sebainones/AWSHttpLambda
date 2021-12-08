
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace HttpLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestFunctionGetTheRightInput()
        {

            //Arrange
            // Invoke the lambda function and confirm the string was processed.

            const string input = "SebasInput";

            var function = new Function();
            var context = new TestLambdaContext();

            //Act
            var response = function.FunctionHandler(input, context);


            //Assert
            var testLogger = context.Logger as TestLambdaLogger;

            //Assert.Equal("HELLO WORLD");
            Assert.Contains($"Processing HTPP Call for {input} ...", testLogger.Buffer.ToString());
            Assert.Contains($"Hello Lambda, from {input}", response.Body);
        }
    }
}
