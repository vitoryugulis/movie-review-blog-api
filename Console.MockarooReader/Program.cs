using System;

namespace ConsoleApp.MockarooReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running mockaroo file handler...");
            var mockarooHandler = new MockarooFileHandler();
            mockarooHandler.InsertMockarooData();
            Console.WriteLine("Done inserting data...");
        }
    }
}
