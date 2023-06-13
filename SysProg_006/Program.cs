using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_006
{
    internal class Program
    {
        public static void Work(object state)
        {
            Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}; State: {state}");
            Thread.Sleep(500);
        }



        static void Main(string[] args)
        {
            //Threadpool

            int nWorkerThread;
            int nCompliionThread;

            ThreadPool.GetMaxThreads(out nWorkerThread, out nCompliionThread);

            Console.WriteLine($"Max size threads: {nWorkerThread}");
            Console.WriteLine($"threads in/out: {nCompliionThread}");

            Random rnd = new Random();
            for( int i = 0; i < 30; i++ ) 
            {
                ThreadPool.QueueUserWorkItem(Work, rnd.Next(0,10));

            }

            Thread.Sleep(2000);

            Console.WriteLine("Osnovnoi thread compl");
        }
    }
}
