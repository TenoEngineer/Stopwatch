using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Seconds \nM = Minutos\n0 = Exit");
            Console.WriteLine("How much time?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0, data.Length-1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }
        static void Start(int time){
            int currertTime = 0;

            while (currertTime != time)
            {
                Console.Clear();
                currertTime++;
                Console.WriteLine(currertTime);
                Thread.Sleep(1000);
            }
        
            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(2500);
            Menu();
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }
    }

}