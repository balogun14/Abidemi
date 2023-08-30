// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("{0}-{1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            System.Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
        }
    }
}