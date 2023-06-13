using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_Abort_Thread_005
{
    internal class Program
    {

        private static void Function()
        {
            while (true) 
            {
                Thread.Sleep(20);
                Console.Write('.');
            }
        }



        static void Main(string[] args)
        {
            Thread thread = new Thread(Function);

            thread.Start();


            Thread.Sleep(2000);

            thread.Abort();


        }
    }
}
