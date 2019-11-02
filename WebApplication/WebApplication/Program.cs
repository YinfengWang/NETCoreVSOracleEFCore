using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // NLog.Web.NLogBuilder.ConfigureNLog("nlog.config"); //没有默认的名字，多写了一个
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                    .UseConfiguration(new ConfigurationBuilder().AddJsonFile(@"appsettings.json", optional: true, reloadOnChange: true).Build())
                    .UseStartup<Startup>().ConfigureLogging(logging =>
                        {
                            logging.ClearProviders();//移除已经注册的其他日志处理程序
                            logging.SetMinimumLevel(LogLevel.Information);//设置最小的日志级别
                            logging.AddConsole();
                        })
                    .UseNLog();
    }
}
