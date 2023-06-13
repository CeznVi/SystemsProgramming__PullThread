using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_Thread_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток выполнения");

            Console.WriteLine($"Id current Thread: {Thread.CurrentThread.ManagedThreadId}");


            Thread thread = new Thread(TaskTwo);
            thread.Priority = ThreadPriority.Lowest;
            thread.Start();

            //thread.Join(); ///команда основному потоку подождать завершения ассинхронной операции

            TaskOne();

            //TaskTwo();


        }

        private static void TaskTwo()
        {
            Console.WriteLine("Task two Start");
            Console.WriteLine($"Id current Thread: {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(30);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("#");
                Console.ResetColor();
            }

            Console.WriteLine("Task two finish");

        }

        private static void TaskOne()
        {
            Console.WriteLine("Task one Start");
            Console.WriteLine($"Id current Thread: {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 0; i < 500; i++) 
            { 
                Thread.Sleep(30);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
                Console.ResetColor();
            }

            Console.WriteLine("Task one finish");

        }
    }
}
