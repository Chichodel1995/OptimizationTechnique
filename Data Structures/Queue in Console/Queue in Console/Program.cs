using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CQueue QueueForTheBank = new CQueue();
            QueueForTheBank.Enqueue(20);
            QueueForTheBank.Enqueue(6);
            QueueForTheBank.Enqueue(9);                       
            QueueForTheBank.Transverse();

            int value = QueueForTheBank.Dequeue();
            Console.WriteLine("The values that was removed is [{0}]", value);
            QueueForTheBank.Transverse();

            QueueForTheBank.Enqueue(7);
            QueueForTheBank.Transverse();

            Console.WriteLine("El first value in the queue is [{0}]" , QueueForTheBank.Peek());

            Console.ReadKey();
        }
    }
}
