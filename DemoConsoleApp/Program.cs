using System;

namespace DemoConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int getNumber()
        {
            return 5;
        }

        public static void throwBadException()
        {
            throw new NotImplementedException("haven't started this code...");
        }
    }
}
