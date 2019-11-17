using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

namespace BitSprite.Helper
{
    static public class WebAPIHelper
    {
        /// <summary>
        /// 启动webapi services
        /// </summary>
        public static  void StartWebService()
        {
            var webHost = new WebHostBuilder().UseStartup<Startup>().UseKestrel(options =>
            {
                options.Limits.MaxConcurrentConnections         = 50000;
                options.Limits.MaxConcurrentUpgradedConnections = 50000;
                options.Limits.MaxRequestBodySize               = 10 * 1024;
                options.Limits.MinRequestBodyDataRate = new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                options.Limits.MinResponseDataRate = new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                options.Listen(IPAddress.Loopback, 10001);
            }).Build();
            
            webHost.Run();
        }
    }
}