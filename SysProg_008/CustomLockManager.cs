using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysProg_008
{
    class CustomLockManager:IDisposable
    {
        private CustomLock _customLock;


        public CustomLockManager(CustomLock customLock)
        {
            _customLock = customLock;
            _customLock.On();
        }


        public void Dispose()
        {
            _customLock.Off();
        }
    }



}
