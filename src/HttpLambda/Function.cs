using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HttpLambda
{
    public class Function
    {

        ///// <summary>
        ///// A simple function that takes a string and does a ToUpper
        ///// </summary>
        ///// <param name="input"></param>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //public string FunctionHandler(string input, ILambdaContext context)
        //{
        //    context.Logger.LogLine($"Processing  {input}  entry...");
        //    return input?.ToUpper();
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(ILambdaContext context)
        {
            context.Logger.LogLine($"Processing HTPP Calllll...");
            return new APIGatewayProxyResponse
            {
                Body = "Hello Lambda, from Sebastian",
                StatusCode = 200
            };
        }
    }
}