using System;

namespace ProgQues
{
    interface I1
    {
        void Cal1();        
    }

    interface I2
    {
        void Cal1();        
    }

    class Program1: I1,I2
    {
        void I1.Cal1()
        {
            Console.WriteLine("I am from I1");
        }

        void I2.Cal1()
        {
            Console.WriteLine("I am from I2");
        }

        private static void PrintMe(int i = 5)
        {
            Console.WriteLine("I am Int");
        }

        private static void PrintMe(string i = "AA")
        {
            Console.WriteLine("I am string");
        }

        static void Main(string[] args)
        {
            //PrintMe("AA"); //OK
            //PrintMe(4); //OK

            //List<int> temp= new List<int> {0,1,2,3,4};
            //foreach (var t in temp)
            //    Console.Write(t);


            //PrintMe(); //Error as it dodn't know which once to use.

            //I1 i1 = new Program();
            //i1.Cal1();

            //I2 i2 = new Program();
            //i2.Cal1();
                       
            //Thread t = new Thread(Fun);
            //t.IsBackground = true;
            //t.Start();
            //CastMe();
        }

        static void Fun()
        {
            //Console.WriteLine("Hello PK");
            Console.ReadLine();
        }

        //class MyClass //Sample class to test the scenario
        //{
        //    int a;
        //    string b;
        //}
         //static void CastMe()
         //{        
            //object name = new MyClass();
            //string test = name as string;
            //if (test != null) //Check if test is not null means i.e. casting can be done
            //{
            //    Console.WriteLine(name);
            //}

            //Singleton obj = Singleton.GetInstance;
            //obj.TestMethod();
            
            //Program to find the difference of days between two dates
            //DateTime dt1 = new DateTime(2011, 6, 1);
            //DateTime dt2 = new DateTime(2011, 6, 24);
            //TimeSpan diff = dt2 - dt1;
            //Console.WriteLine(diff.ToString().Substring(0,diff.ToString().IndexOf('.')));
                       
            //object length = 3.2;
            //int test = (int)length; //Fails in runtime
            //Console.WriteLine(test);

            //object length = 3.2;
            //if (length is int) //Check if length can be cast to int
            //{
            //    Console.WriteLine(length);
            //}                        

            //float amount = 3.2f;
            //object amountRef = amount;
            //int ballance = (int)(float)amountRef;
            //Console.WriteLine(ballance);            
        //}
    }
}
