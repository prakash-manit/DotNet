using System;

namespace ProgQues
{
    class Program4
    {
        static void Main4(string[] args)
        {
            //Console.WriteLine($"{CalculateFact(5)}");
            //Console.WriteLine($"{CalculateFactRec(5)}");

            char[] str1 = ("geeksforgeeks").ToCharArray();
            char[] str2 = ("forgeeksgeeks").ToCharArray();

            if (areAnagram(str1, str2))
                Console.WriteLine("The two strings are"
                                  + "anagram of each other");
            else
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");

        }

        static int NO_OF_CHARS = 256;

        static bool areAnagram(char[] str1, char[] str2)
        {
            // Create 2 count arrays and initialize 
            // all values as 0 
            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];

            if (str1.Length != str2.Length)
                return false;

            int i;

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array 
            for (i = 0; i < str1.Length && i < str2.Length; i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }          
          
            // Compare count arrays 
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }

        private static int CalculateFactRec(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * CalculateFactRec(num - 1);         
        }

        private static int CalculateFact(int num)
        {
            int fact = 1;
            for (int i = 1; i<= num; i++)
            {
                fact = fact* i;
            }
            return fact;
        }
    }
}
