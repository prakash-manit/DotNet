using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewQues
{
    class CustomThread
    {
        static void Main01(string[] args)
        {
            //CustomThread.Func1();
            //CustomThread.Func2();

            Thread t1 = new Thread(Func3);
            //t1.IsBackground = true;
            t1.Start();
            Console.WriteLine("Main thread exited");

            //Thread t1 = new Thread(Func1);
            //t1.Start();
            //Thread t2 = new Thread(Func2);
            //t2.Start();

            //Thread t1 = new Thread(RunMillionIterations);
            //t1.Start();

            //TPL
            //Parallel.For(0, 1000000, x => RunMillionIterations());
            //Console.ReadKey();
        }
        
        static void Func1 ()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func1 executed {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func2 executed {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Func3()
        {
            Console.WriteLine("Fun3 is started");
            Console.ReadKey();
            Console.WriteLine("Fun3 is ended");
        }

        static void RunMillionIterations()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + "a";
            }
            Console.Write(x);
        }
    }
}
