using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;

namespace BasicWebServerSite
{
    class Program
    {
        static void Main(string[] args) => WebHost
            .CreateDefaultBuilder()
            .Configure(app =>
            {
                app.Run(context => context.Response.WriteAsync($"<h1> Welcome to {DateTime.Now.Year} :) </h1>"));
            })
            .Build()
            .Run();
    }
}
