using System;

namespace ProgQues
{
    class Base
    {
	    internal void DoWork()
        {
            Console.WriteLine("From Base");
        }
    }

    class Derived: Base
    {
        internal void DoWork()
        {
            Console.WriteLine ("From Derived");
        }
        internal void DoMoreWork()
        {
            Console.WriteLine("New Derived");
        }
    }

    class Program3
    {
        static void Main3(string[] args)
        {
            //Derived d1 = new Base(); //Doesn't work why?
            Base b1 = new Derived(); 
            b1.DoWork(); //Execute Base method why?

            Base b2 = new Base();
            b2.DoWork();
            Derived d1 = new Derived();
            d1.DoMoreWork(); //Will it work?            

            //char c1 = ' ';
            //char c2 ='\0';
            //char c3 = 'm';
            ////int i;
            //String s = "";
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);

            //Console.WriteLine(s);
            //Console.WriteLine(i);

            //Console.WriteLine("\t\t*\t\t");
            //Console.WriteLine("\t*\t*\t*\t");
            //Console.WriteLine("*\t*\t*\t*\t*");

            //int a = 5; 
            //GC.Collect();
            //Console.WriteLine(a);
        }
    }    
}
