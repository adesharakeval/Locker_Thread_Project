using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Locker_Thread_5
{
    class ThreadSafe
    {
        static bool done;
        static object locker = new object();
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadLine();
        }
        static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                   // done = true;
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }
    }
}
