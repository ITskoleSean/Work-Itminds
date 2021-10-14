using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentCustomer = Customers
                .Create("Kim")
                .Previous("Hans")
                .Previous("Ole")
                .Previous("Peter");

            while (currentCustomer != null)
            {
                if (currentCustomer.Next != null)
                    Console.Write(currentCustomer.Person + " -> ");
                else
                    Console.WriteLine(currentCustomer.Person);

                currentCustomer = currentCustomer.Next;
            }

            Console.ReadLine();
        }
    }
}
