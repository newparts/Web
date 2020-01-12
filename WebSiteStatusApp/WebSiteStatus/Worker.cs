using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebSiteStatus
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient client;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("Serviciul a fost oprit");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var result = await client.GetAsync("http://www.newparts.ro");

                if (result.IsSuccessStatusCode)
                {
                    _logger.LogInformation("Situl functioneaza bine! Status code {StatusCode}", result.StatusCode);
                }
                else
                {
                    _logger.LogError("Situl este mort! Status code {StatusCode}", result.StatusCode);
                }
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
