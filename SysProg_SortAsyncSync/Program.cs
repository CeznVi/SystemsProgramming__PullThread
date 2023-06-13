using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_SortAsyncSync
{
    internal class Program
    {

        public static void showArray(int[][] arr)
        {
            foreach (var item in arr)
            {
                foreach(var item2 in item) 
                {
                    Console.Write(item2 +" ");
                }
                Console.WriteLine();
            }
        }
        
        public static void SyncSort(object o)
        {
            int[] arr = o as int[];

            Array.Sort(arr);
        }



        public static void RunASyncSort(int[][] _arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

           for(int i = 0; i < _arr.Length; i++)
            {
                ThreadPool.QueueUserWorkItem(SyncSort, _arr[i]);
            }

           sw.Stop();
           
            Console.WriteLine($"Elaplsed time(ticks) ASYNC SORT  {sw.ElapsedTicks}");
        }

        public static void SyncSort(int[][] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int i = 0;i < arr.Length ; i++) 
            {
                Array.Sort(arr[i]);
            }

            sw.Stop();

            Console.WriteLine($"Elaplsed time(ticks) SYNC SORT  {sw.ElapsedTicks}");
        }



        static void Main(string[] args)
        {
            int[][] _arr;

            Random rand = new Random();

            ////CREATE ARRAY
            _arr = new int[1000][];

            for (int i=0; i<1000; i++)
            {
                _arr[i] = new int[1000];

                for(int j=0; j<1000; j++)
                {
                    _arr[i][j] = rand.Next(0,1000);
                }

            }
            ////CREATE ARRAY ---- END

            int[][] _arr2 = new int[1000][];
            
            ////COPY ARRAY
            Array.Copy(_arr, _arr2, _arr.Length);
      

            RunASyncSort(_arr);

            SyncSort(_arr2);



        }




    }
}
