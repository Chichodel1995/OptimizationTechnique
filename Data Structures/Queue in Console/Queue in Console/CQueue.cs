using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Console
{
    class CQueue
    {
        CSimpleNode anchor;
        CSimpleNode work;

        public CQueue()
        {
            anchor = new CSimpleNode();
            anchor.NextNode = null;
        }

        //Coloca un dato en la última fila de la cola.
        public void Enqueue(int pDate)
        {
            
            work = anchor;

            while (work.NextNode != null)
            {
                work = work.NextNode;
            }

            CSimpleNode temporaryNode = new CSimpleNode();
            temporaryNode.Date = pDate;
            temporaryNode.NextNode = null;
            work.NextNode = temporaryNode;
        }

        public int Dequeue()
        {
            int value = 0;
            
            if (anchor.NextNode != null)
            {
                work = anchor.NextNode;
                value = work.Date;
                anchor.NextNode = work.NextNode;
                //Al estar apuntando a un objeto de referencia vacío, se eliminar de la memoria
                // por el Garbage Collector.
                work.NextNode = null;
            }
            return value;
        }

        public int Peek()
        {
            int value = 0;
            if (anchor.NextNode != null)
            {
                work = anchor.NextNode;
                value = work.Date;
            }
            return value;
        }

        public void Transverse()
        {
            work = anchor;

            while (work.NextNode != null)
            {
                work = work.NextNode;
                int date = work.Date;
                Console.Write(" <- [{0}]", date);
            }
            Console.WriteLine();
        }
    }
}
