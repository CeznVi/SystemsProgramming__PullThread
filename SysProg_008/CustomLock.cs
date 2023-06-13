using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysProg_008
{
    class CustomLock
    {
        private int _block;   /// 0 - unblock ; 1 - block
        private readonly int _wait;  //interval через которій потоки будут проверять статус блокировки



        public CustomLock(int wait)
        {
            _wait = wait;
        }

        public void On()
        {
            int result = Interlocked.CompareExchange(ref _block, 1, 0);

            while (result == 1) 
            { 
                Thread.Sleep(_wait);
                result = Interlocked.CompareExchange(ref _block, 1, 0);
            }

        }

        public void Off()
        {
            Interlocked.CompareExchange(ref _block, 0, 1);
        }



    }
}
