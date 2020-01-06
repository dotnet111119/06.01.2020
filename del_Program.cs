using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3012T
{

    class Program
    {

        delegate void Method_Signature_return_void_accepts_int(int x);

        static void Do1(int  x)
        {
            Console.WriteLine($"i got {x}");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        static void Do2(int x)
        {
            Console.WriteLine($"i got {x}");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {

            Method_Signature_return_void_accepts_int del1 = Do1;
            
            //Do1(5);
            //del1.Invoke(5); // same as Do1(5)
            del1.BeginInvoke(5, null, null);
            Thread.Sleep(1000);
        }
    }
}
