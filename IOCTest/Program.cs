using Autofac;
using IOCTest.Interface;
using IOCTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {


            //{
            //    ConsoleOutput c = new ConsoleOutput();
            //    c.Write(DateTime.Now.ToString());
            //}

            //{
            //    ConsoleOutput c = new ConsoleOutput();
            //    TodayWriter tw = new TodayWriter(c);
            //    tw.WriteDate();
            //}

            //{
            //    Console.WriteLine("明天当前日期为:");
            //    ConsoleOutput c = new ConsoleOutput();
            //    TomorrowWriter tw = new TomorrowWriter(c);
            //    tw.WriteDate();
            //}

            {
                var builder = new ContainerBuilder();
                builder.RegisterType<ConsoleOutput>().As<IOutput>();
                builder.RegisterType<TodayWriter>().As<IDateWriter>();
                Container = builder.Build();
                WriteDate();

                builder = new ContainerBuilder();
                builder.RegisterType<ConsoleOutput>().As<IOutput>();
                builder.RegisterType<TomorrowWriter>().As<IDateWriter>();
                Container = builder.Build();
                WriteDate();
            }
            Console.ReadLine();
            //添加了注释,haha
        }

        public static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
