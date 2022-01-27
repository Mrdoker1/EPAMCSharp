using System;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, world!\n");
        }

        public static void SayHelloUser(string userName)
        {
            string name = userName;
            try
            {
                Console.WriteLine($"Hello, " + name + "!\n");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void PrintFace()
        {
            try
            {
                Console.WriteLine(" +\"\"\"\"\"+\n" + "(| o o |)\n" + " |  ^  |\n" + " | \'-\' |\n" + " +-----+");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}