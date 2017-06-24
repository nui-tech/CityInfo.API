using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder() //hosting a web application
                .UseKestrel()       //web server
                .UseContentRoot(Directory.GetCurrentDirectory())    //specify content root directory that use by the web host
                .UseIISIntegration()
                .UseStartup<Startup>()      //startup type that use by the web host (startup.cs)
                .UseApplicationInsights()
                .Build();           //build web

            host.Run();
        }
    }
}
