using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_008
{
    internal class Program
    {
        private static readonly FileStream _fileStream = File.Open("erorrs.log", FileMode.Append, FileAccess.Write);
        private static StreamWriter _streamWriter = new StreamWriter(_fileStream);

        private static Random _random = new Random();

        private static CustomLock _customLock = new CustomLock(10);


        private static void FileWriteWork()
        {
            using(new CustomLockManager(_customLock))
            {
                _streamWriter.WriteLine($"Code {_random.Next(100,151)}; Date {DateTime.Now}; " +
                    $"THread id {Thread.CurrentThread.GetHashCode()}");

                _streamWriter.Flush();
            }
            Thread.Sleep(_random.Next(10,200));
        }


        static void Main(string[] args)
        {
            ///.log

            Thread[] threads = new Thread[50];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(FileWriteWork);
                threads[i].Start();
            
            }
            Console.ReadKey();

        }
    }
}
