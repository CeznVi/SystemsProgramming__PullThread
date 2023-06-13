using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_Thread_003
{
    internal class Program
    {
        static object block = new object();

        public static void TaskNotBlocked() 
        {
            Console.WriteLine("Старт не заблокированого потока");
            Console.WriteLine($"Id текущего Thread: {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 0; i < 10; i++) 
            { 
                Thread.Sleep(250);
                Console.WriteLine(i);
            }


            Console.WriteLine("Финиш не заблокированого потока");
        }

        public static void TaskBlocked()
        {
            lock (block) 
            {
                Console.WriteLine("Старт блокированого потока");
                Console.WriteLine($"Id текущего Thread: {Thread.CurrentThread.ManagedThreadId}");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(250);
                    Console.WriteLine(i);
                }


                Console.WriteLine("Финиш блокированого потока");
            }
        }


        static void Main(string[] args)
        {
            //общий ресурс
            //lock

            Thread thread1 = new Thread(TaskNotBlocked);
            Thread thread2 = new Thread(TaskNotBlocked);
            Thread thread3 = new Thread(TaskNotBlocked);

            Thread thread4 = new Thread(TaskBlocked);
            Thread thread5 = new Thread(TaskBlocked);
            Thread thread6 = new Thread(TaskBlocked);



            thread1.Start();
            thread2.Start(); 
            thread3.Start();

            ///поочередно через блокировщик
            thread4.Start();
            thread5.Start();    
            thread6.Start();

        }
    }
}
