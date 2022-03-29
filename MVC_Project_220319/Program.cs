using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVC_Project_220319.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_220319
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //var host = CreateHostBuilder(args).Build();
            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider; //�X�ݨt�Ψ̿�e��
            //    try
            //    {
            //        //����ƾڮw���s����H
            //        var context = services.GetRequiredService<MvcTestDbContext>();
            //        //�b�U�ުA�Ⱦ��B��e�A�K�[���ռƾ�
            //        DbInitializer.Seed(context); 
            //    }
            //    catch(Exception)
            //    {
            //        //����K�[��x
            //    }
            //}

            //host.Run();



        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
