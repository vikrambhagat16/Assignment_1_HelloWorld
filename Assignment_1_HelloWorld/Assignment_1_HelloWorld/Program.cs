using System;

namespace Assignment_1_HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var transaction = new Transaction(50, DateTime.Now, "Coffee");
            transaction.printAccountDetails();
            transaction = new Transaction(232, DateTime.Now, "Tea");
            transaction.printAccountDetails();
            transaction = new Transaction(123, DateTime.Now, "Tea Bag");
            transaction.printAccountDetails();

        }
    }
}
