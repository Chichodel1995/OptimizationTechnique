using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_in_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack stackFruits = new CStack();

            stackFruits.Push("Apple");
            stackFruits.Push("Orange");
            stackFruits.Push("Banana");
            stackFruits.Push("Grapefruit");

            stackFruits.Transverse();

            Console.WriteLine("\n ****** \n");

            stackFruits.Pop();

            stackFruits.Transverse();

            Console.WriteLine("\n ****** \n");

            Console.WriteLine("The last of the stack is [{0}]",stackFruits.Peek());

            Console.ReadKey();
        }
    }
}
