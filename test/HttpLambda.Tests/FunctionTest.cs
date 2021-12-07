
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace HttpLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            //Arrange
            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            
            //Act
            function.FunctionHandler(context);


            //Assert
            var testLogger = context.Logger as TestLambdaLogger;

            //Assert.Equal("HELLO WORLD");
            Assert.Contains("Processing HTPP Calllll...", testLogger.Buffer.ToString());
        }
    }
}
