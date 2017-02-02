using System;
using System.Threading;

namespace Exercise_4Thrads 
    
    {
    class Program
        {
        static void Main(string[] args)
            {
            Thread Temp = new Thread(temp);
            Temp.Start();
             Temp.Join();
            }
        public static void temp()
            {
            string a = "C";
            for (int counter = 0; counter<5; counter++)
                {
                Random temprature = new Random();
                int number = temprature.Next(-20 , 120);

                if (number<0)
                    
                    {
                    Console.Write(a+number);
                    Console.Write("      temprature is low ");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    }
                else if (number>100)
                    {
                    Console.Write(a+number);
                    
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.Write("      temprature is too high ");
                    }
                Console.WriteLine(a+number);
                Thread.Sleep(1000);
                }
            }
        }
    }


    