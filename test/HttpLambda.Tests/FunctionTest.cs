using Xunit;
using Amazon.Lambda.TestUtilities;
using HttpLambda.Models;

namespace HttpLambda.Tests
{
    public class FunctionTest
    {

        [Fact]
        public void TestFunctionGetTheRightInput()
        {

            //Arrange
            // Invoke the lambda function and confirm the string was processed.

            Persona personaDePrueba = new Persona() { Nombre = "Test", Apellido = "Case" };

            var function = new Function();
            var context = new TestLambdaContext();

            //Act
            var response = function.FunctionHandler(personaDePrueba, context);

            //Assert
            var testLogger = context.Logger as TestLambdaLogger;

            Assert.Contains($"Tiene body ...{ personaDePrueba.Nombre}", testLogger.Buffer.ToString());
            Assert.Contains($"Hello Lambda, from {personaDePrueba.Nombre}", response.Body);
        }
    }
}
