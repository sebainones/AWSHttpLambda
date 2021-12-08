using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;


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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        //public APIGatewayProxyResponse FunctionHandler(string input, ILambdaContext context)
        //{
        //    context.Logger.LogLine($"Processing HTPP Call for {input} ...");
        //    return new APIGatewayProxyResponse
        //    {
        //        Body = $"Hello Lambda, from {input}",
        //        StatusCode = 200
        //    };
        //}

        public APIGatewayProxyResponse FunctionHandler(ILambdaContext context)
        {
            context.Logger.LogLine($"Processing HTPP Call for ESTATICO ...");
            return new APIGatewayProxyResponse
            {
                Body = $"Hello Lambda, from ESTATICO",
                StatusCode = 200
            };
        }
    }
}