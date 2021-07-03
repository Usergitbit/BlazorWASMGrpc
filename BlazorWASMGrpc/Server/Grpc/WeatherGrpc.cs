using BlazorWASMGrpc.Shared;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMGrpc.Server.Grpc
{
    public class WeatherGrpc : WeatherProto.WeatherProtoBase
    {
        public override Task<GetReply> Get(GetRequest request, ServerCallContext context)
        {
            var reply = new GetReply
            {
                WeatherForecast = new WeatherForecast
                {
                    Date = Timestamp.FromDateTime(DateTime.UtcNow),
                    Summary = "summary",
                    TemperatureC = 35,
                    TemperatureF = 100
                }
            };

            return Task.FromResult(reply);
        }
    }
}
