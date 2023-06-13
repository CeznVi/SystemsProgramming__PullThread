using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_007
{
    internal class Program
    {

        private static long _counter = 10;  //obshii resurs
        private static Random _random = new Random();

        private static void Work()
        {
            //_counter++;   //thread not safe

            Interlocked.Increment(ref _counter);

            Console.WriteLine(_counter.ToString(), "+");
            try
            {
                Thread.Sleep(_random.Next(10,50));
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //_counter--;
                Interlocked.Decrement(ref _counter);
                Console.WriteLine($"Counter: { _counter}");
            }
               
        }

        public static void Report()
        {
            while(true) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine($"Zanchenie countera {_counter}");
                Console.WriteLine($"Zanchenie countera {Interlocked.Read(ref _counter)}");

                Console.ResetColor();
                Thread.Sleep(100);
            }
        }



        static void Main(string[] args)
        {
            ///Interlocked

            Thread threadReported = new Thread(Report);
            threadReported.Start();

            Thread[] threads = new Thread[100];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] =  new Thread(Work);
                threads[i].Start();
            }

            Thread.Sleep(15000);



        }
    }
}
