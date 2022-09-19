using Demo_Entity_Framework_CodeFirst1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Entity_Framework_CodeFirst1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            using (var ctx = new RecordContext())
            {
                var student1 = new Student() { Name = "Ridhi", Course = "Database", ID = 001, Contact = "9367677878", Email = "ridhi.rani@intsof.com" };
                ctx.Students_Ridhief.Add(student1);
                ctx.SaveChanges();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
