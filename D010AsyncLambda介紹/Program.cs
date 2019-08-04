using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D010AsyncLambda介紹
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Start This Tread ID:{Thread.CurrentThread.ManagedThreadId}");

            Task.Run(async () =>
            {
                await Task.Delay(3000);
                Console.WriteLine($"Task.Run Thread ID:{Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"END");

            Console.Read();
        }
    }
}
