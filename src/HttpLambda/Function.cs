using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using HttpLambda.Models;

//[LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
//If you are using .NET Core 3.1, we recommend that you use the
//Amazon.Lambda.Serialization.SystemTextJson serializer.
//This package provides a performance improvement over Amazon.Lambda.Serialization.Json.
// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HttpLambda
{
    public class Function
    {
        public APIGatewayProxyResponse FunctionHandler(Persona requestPersona, ILambdaContext context)
        {
            context.Logger.LogLine($"Processing HTPP Call for lambdaRequest ...");

            if (!string.IsNullOrEmpty(requestPersona?.Nombre))
                context.Logger.LogLine($"Tiene body ...{ requestPersona.Nombre}");


            context.Logger.LogLine($"Processing persona: {requestPersona.Nombre} {requestPersona.Apellido}");

            return new APIGatewayProxyResponse
            {
                Body = $"Hello Lambda, from {requestPersona.Nombre}",
                StatusCode = 200
            };
        }
    }
}