using System;
using System.Threading;

namespace SysProg_004
{
    internal class Program
    {
        public static void ShowSymbol(object obj)
        {

            Console.WriteLine($"Id current Thread: {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 0; i < 10000; i++) 
            {
                Console.ForegroundColor = ((Controller)obj).Color;
                Console.Write(((Controller)obj).Symbol);
            }
        }

        /// <summary>
        /// Класс обертка
        /// </summary>
        class Controller
        {
            public char Symbol { get; set; }
            public ConsoleColor Color { get; set; }
        }



        static void Main(string[] args)
        {
            Thread thread01 = new Thread(new ParameterizedThreadStart(ShowSymbol));
            Thread thread02 = new Thread(new ParameterizedThreadStart(ShowSymbol));
            Thread thread03 = new Thread(new ParameterizedThreadStart(ShowSymbol));

            thread01.Start(new Controller() { Symbol ='+', Color=ConsoleColor.Red});
            thread02.Start(new Controller() { Symbol = '-', Color = ConsoleColor.Magenta });
            thread03.Start(new Controller() { Symbol = '%', Color = ConsoleColor.Blue });


        }
    }
}
