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
            int count = 0;
            while (count<3)
                {
                string a = "C";
                for (int counter = 0; counter<1; counter++)
                    {
                    Random temprature = new Random();
                    int number = temprature.Next(-20 , 120);
                    if (number<0||number>100)
                        {
                        count++;
                        Console.Write(a+number);
                        Console.Write("      temprature is low ");
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        }
                    Console.WriteLine(a+number);
                    Thread.Sleep(1000);
                    }
                }
            Console.WriteLine("Exit");
            Console.ReadKey();
            }       
        }
    }


