using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewQues
{
    class Program2
    {
        static void Main2(string[] args)
        {
            //Hack.Encript2();
            Console.WriteLine(Hack.Check("6210001000"));
            //Hack.Test();
            //CheckAssembly();
            //Console.WriteLine(MyExtensions.WordCount("Test  SD  DD CC"));
            //StringnStringBuilder();
            //Que.GetAllUniqueSetWhoseSumIsGivenNumber(5);
            //int [] result = ArrayManipulation.ReplaceArrayElementWithSum(new int[] { 5, 12, 18, 22, 27 });
            //foreach (int a in result )
            //{
            //    Console.WriteLine(a);
            //}

            //if (!DBNull.Value.Equals(row[fieldName]))
            //    return (string)row[fieldName] + " ";
            //else
            //    return String.Empty;

            //SqlDataReader r = ...;
            //String firstName = getString(r[COL_Firstname]);

            //private static string getString(object o) {
            //   if (o == DBNull.Value) return null;
            //   return (string) o;
            //} 
        }

        //private static void CheckAssembly()
        //{
        //    Console.WriteLine(Assembly.GetAssembly(new Program().GetType()));
        //    Console.WriteLine(Assembly.GetCallingAssembly());
        //    Console.WriteLine(Assembly.GetEntryAssembly());
        //    Console.WriteLine(Assembly.GetExecutingAssembly());
        //}               
        private static void StringnStringBuilder()
        {
            //string a = "prakash";
            //string b = "p";
            //b += "rakash";  // Append to contents of 'b'
            //Console.WriteLine(a == b);  //True
            //Console.WriteLine((object)a == (object)b); //False

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello ");
            //sb.Append("Prakash");
            //Console.WriteLine(sb.ToString());

            //// Bad code! Do not use!
            //StringBuilder builder = new StringBuilder();
            //builder.Append(firstName);
            //builder.Append(" ");
            //builder.Append(lastName);
            //string name = builder.ToString();


            int dt1 = DateTime.Now.Millisecond;
            Console.WriteLine();
            string x = "";
            for (int i = 0; i < 100000; i++)
            {
                x += "!";
            }
            int dt2 = DateTime.Now.Millisecond;
            Console.WriteLine("Time taken in string concatenation: {0} MS", dt2 - dt1);

            int dt3 = DateTime.Now.Millisecond;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("!");
            }
            x = builder.ToString();
            int dt4 = DateTime.Now.Millisecond;
            Console.WriteLine("Time taken in StringBuilder concatenation: {0} MS", dt4 - dt3);
        }
    }

    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
