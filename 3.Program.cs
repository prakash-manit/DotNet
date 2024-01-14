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

            //Sort s = new Sort();
            //int [] arr = new int[] {8, 6, 5, 3, 1};
            ////s.BubbleSort(arr);
            //s.InsertionSort(arr);

            //Console.WriteLine("\t\t*\t\t");
            //Console.WriteLine("\t*\t*\t*\t");
            //Console.WriteLine("*\t*\t*\t*\t*");

            //Queue que = new Queue();
            //Console.WriteLine("Enqued: {0}" ,que.Enque(10));
            //Console.WriteLine("Enqued: {0}", que.Enque(8));
            //Console.WriteLine("Enqued: {0}", que.Enque(7));
            //Console.WriteLine("Enqued: {0}", que.Enque(13));
            //Console.WriteLine("Enqued: {0}", que.Enque(15));

            //Console.WriteLine("Dequed: {0}", que.Deque());
            //Console.WriteLine("Dequed: {0}", que.Deque());
            //Console.WriteLine("Dequed: {0}", que.Deque());

            //ReverseNumber.ReverseNumber1(100);
            //Palindrome.ReverseString("12321");

            //int a = 5; 
            //GC.Collect();
            //Console.WriteLine(a);

            //PrimePrint.PrintPrimeNumber1(100);
            //PrimePrint.PrintPrimeNumber2(100);
            //PrimePrint.PrintPrimeNumber3(100);
            //PrimePrint.PrintPrimeNumber4(100);

            //LinkedList ll = new LinkedList();
            ////Console.WriteLine("Size: {0}", ll.Size());
            //Console.WriteLine("Added Item: {0}", ll.Insert(10));
            //Console.WriteLine("Added Item: {0}", ll.Insert(11));
            //Console.WriteLine("Added Item: {0}", ll.Insert(12));
            //Console.WriteLine("Added Item: {0}", ll.Insert(8));
            //Console.WriteLine("Added Item: {0}", ll.Insert(7));
            //Console.WriteLine();
            //Console.Write("Size: {0}", ll.Size());
            //ll.Print();
            //ll.InsertAfter(12, 15);
            //ll.Print();
            //ll.ReversePrint();
            //ll.SplitPrint();
            //ll.Find(10);
            //ll.Find(13);

            //Console.WriteLine("Deleted Item: {0}", ll.Delete());
            //Console.WriteLine("Deleted Item: {0}", ll.Delete());           
            //Console.WriteLine("Size: {0}", ll.Size());
            //ll.Print();
            //Console.WriteLine("Deleted Item: {0}", ll.Delete());
            //Console.WriteLine("Deleted Item: {0}", ll.Delete());           
            //Console.WriteLine("Size: {0}", ll.Size());
            //ll.Print();
            //Stack_Array sa = new Stack_Array();
            //Console.WriteLine(sa.Peek());
            //Console.WriteLine(sa.Pop());
            //Console.WriteLine(sa.Push(2));
            //Console.WriteLine(sa.Push(1));
            //Console.WriteLine(sa.Push(3));
            //Console.WriteLine(sa.Pop());
            //Console.WriteLine(sa.Peek());
            //Console.WriteLine(sa.Pop());
            //Console.WriteLine(sa.Peek());
        }       
    }

    
}
