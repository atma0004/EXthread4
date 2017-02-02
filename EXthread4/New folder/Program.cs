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
                string a = "°C";
                for (int counter = 0; counter<1; counter++)
                    {
                    Random temprature = new Random();
                    int number = temprature.Next(-20 , 120);
                    if (number<0||number>100)
                        {
                        count++;
                        Console.Write(number+a);
                        Console.Write("      temperature is outside the legal range ");
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        }
                    Console.WriteLine(number+a);
                    Thread.Sleep(1000);
                    }
                }
            Console.WriteLine("Alarm-wire terminated");
            Console.ReadKey();
            }       
        }
    }


