using System;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running linked list tests...");
            Console.WriteLine();

            Console.WriteLine("Initializing linked list");
            LinkedList list = new LinkedList();
            Console.WriteLine();

            Console.WriteLine("Is linked list empty? {0}", list.Empty);
            Console.WriteLine();

            Console.WriteLine("Adding items to linked list...");
            for (int i = 0; i < 6; i++)
            {
                list.AddToEnd(i);
            }
            list.PrintAllNodeData();
            Console.WriteLine();

            Console.WriteLine("Adding items to beginning of linked list...");
            for (int i = 1; i < 6; i++)
            {
                list.AddToBeginning(i);
            }
            list.PrintAllNodeData();
            Console.WriteLine();

            Console.WriteLine("Searching for '3' within linked list... Is found? {0}", list.IsFound(3));
        }
    }
}
