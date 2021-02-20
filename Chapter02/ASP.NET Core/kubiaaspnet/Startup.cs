using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;

namespace kubiaaspnet
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILogger<Startup> logger)
        {
            app.Run(async context =>
            {
                logger.LogInformation($"Received request for {context.Request.GetDisplayUrl()} from {context.Connection.RemoteIpAddress}");
                await context.Response.WriteAsync($"Hey there, this is {Environment.MachineName}. Your IP is {context.Connection.RemoteIpAddress}.\n");
            });
        }
    }
}
