using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InterviewQues
{
    public class Hack
    {
        public static void Encript()
        {
            string fileName = @"D:\Workspace.bmp";
            Byte [] inputByte = File.ReadAllBytes(fileName);
            Byte[] filteredByte = new Byte[281724];
            Byte[] finalbytes = new Byte[35216];
            int j = 0;
            int count = 0;
            int count2 = 0;
            string bit = string.Empty;
            for (long i = 101; i < inputByte.Length; i += 3)
            {
                filteredByte[j] = inputByte[i];               

                if (((count % 8) != 0) || (count == 0))
                {
                    bit = bit + Convert.ToString(Convert.ToString(filteredByte[j], 2)[Convert.ToString(filteredByte[j], 2).Length - 1]);
                   count++;
                }
                else
                {
                    Console.WriteLine(Convert.ToInt64(bit, 2).ToString());                    
                    count2++;
                    count++;
                }                               
                j++;
            }

            //BitArray bits = new BitArray(filteredByte);

            //for (int counter = 0; counter < bits.Length; counter++)
            //{
            //    Console.Write(bits[counter] ? "1" : "0");
            //    if ((counter + 1) % 8 == 0)
            //        Console.WriteLine();
            //}

            //inputbits = new BitArray(data[i]);
            //outputbits[j] = inputbits[inputbits.Length - 1];   
                //encrypt.Add(BitConverter.GetBytes(outputbits);
            

            //File.WriteAllBytes(@"E:\Workspace2.bmp", encrypt.ToArray());
            //encrypt.ToArray().Dump();
            //System.Text.Encoding.ASCII.GetString(encrypt.ToArray()).Dump();
        }

        public static void Encript2()
        {
            string fileName = @"D:\9ca4082f-74c9-446f-ab67-63f829481082-image.bmp";
            Byte[] inputByte = File.ReadAllBytes(fileName);
            //Byte[] filteredByte = new Byte[281724];
            Byte[] finalbytes = new Byte[2];
            finalbytes[0] = inputByte[0];
            finalbytes[1] = inputByte[inputByte.Length - 1];
            int j = 0;
            //int count = 0;
            //int count2 = 0;
            string bit = string.Empty;
            for (long i = 0; i < finalbytes.Length; i++)
            {               
                
                    Console.WriteLine(Convert.ToInt64(finalbytes[i].ToString(), 2).ToString());

                    //finalbytes[count2] = Convert.ToByte(bit);
                    //count2++;
                    //count++;
                }
                //string bit = Convert.ToString(Convert.ToString(filteredByte[j], 2)[7]);                
                //j++;
            }

            public static void Test ()
            {
            for (int a = 0; a < 10; a++)
                for (int b = 0; b < 10; b++)
                    for (int c = 0; c < 10; c++)
                        for (int d = 0; d < 10; d++)
                            for (int e = 0; e < 10; e++)
                                for (int f = 0; f < 10; f++)
                                    for (int g = 0; g < 10; g++)
                                        for (int h = 0; h < 10; h++)
                                            for (int i = 0; i < 10; i++)
                                                for (int j = 0; j < 10; j++)
                                                    if (Check(a.ToString() +
                                                              b.ToString() +
                                                              c.ToString() +
                                                              d.ToString() +
                                                              e.ToString() +
                                                              f.ToString() +
                                                              g.ToString() +
                                                              h.ToString() +
                                                              i.ToString() +
                                                              j.ToString()))
                                                    {
                                                        string aa = "";
                                                    }

        }

            public static bool Check(string s)
            {

                for (int i = 0; i < 10; i++)
                {
                    if (Count(s, i) != s[i] - 48)
                    {
                        return false;
                    }
                }
                return true;
            }

            private static int Count(string s, int pos)
            {
                int num = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (s[i] == (char)(48 + pos))
                    {
                        num++;
                    }
                }
                return num;
            }
        }
    }
