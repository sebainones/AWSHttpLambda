
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace HttpLambda.Tests
{
    public class FunctionTest
    {
        //[Fact]
        //public void TestFunctionStatic()
        //{

        //    //Arrange
        //    // Invoke the lambda function and confirm the string was processed.

        //    const string input = "ESTATICO";

        //    var function = new Function();
        //    var context = new TestLambdaContext();

        //    //Act
        //    //var response = function.FunctionHandler(input, context);

        //    var response = function.FunctionHandler(context);


        //    //Assert
        //    var testLogger = context.Logger as TestLambdaLogger;

        //    //Assert.Equal("HELLO WORLD");
        //    Assert.Contains($"Processing HTPP Call for {input} ...", testLogger.Buffer.ToString());
        //    Assert.Contains($"Hello Lambda, from {input}", response.Body);
        //}

        [Fact]
        public void TestFunctionGetTheRightInput()
        {

            //Arrange
            // Invoke the lambda function and confirm the string was processed.

            const string input = "ESTATICO";

            var function = new Function();
            var context = new TestLambdaContext();

            //Act
            //var response = function.FunctionHandler(input, context);

            var response = function.FunctionHandler(input, context);


            //Assert
            var testLogger = context.Logger as TestLambdaLogger;

            //Assert.Equal("HELLO WORLD");
            Assert.Contains($"Processing HTPP Call for {input} ...", testLogger.Buffer.ToString());
            Assert.Contains($"Hello Lambda, from {input}", response.Body);
        }
    }
}
