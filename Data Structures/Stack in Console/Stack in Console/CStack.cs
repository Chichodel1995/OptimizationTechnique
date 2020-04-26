using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack_in_Console
{
    class CStack
    {
        //Declaramos variables de referencia.
        private CSimpleNode inicio;
        private CSimpleNode work;

        //Constructor
        public CStack()
        {
            //Instanciamos un objeto.
            inicio = new CSimpleNode();
            //Como la pila está vacia, apuntamos al siguiente nodo un -null-.
            inicio.NextNode = null;
        }

        //Este método está creando un nuevo objeto de tipo CSimpleNode.
        //Inicio funciona como un anclaje en lo cual, ese nodo siempre está vacio aputando a un objeto temporal utilizando la propiedad NextNode.
        public void Push(string pDate)
        {            
            CSimpleNode temporaryNode = new CSimpleNode();
            temporaryNode.Date = pDate;
            temporaryNode.NextNode = inicio.NextNode;

            inicio.NextNode = temporaryNode;
        }

        //Este se encarga de quitar el último nodo de la pila.
        public string Pop()
        {
            string stringBox = null;
            if (inicio.NextNode != null)
            {
                work = inicio.NextNode;
                stringBox = work.Date;
                inicio.NextNode = work.NextNode;
                /*Al indicar que el último nodo en ese momento apunte a null queda fuera de la pila y el administrador de memoria se encargará de limpiar.
                 * * En este casao, automáticamente por el garbage collector.*/
                work.NextNode = null;
            }
            else
            {
                Console.WriteLine("The stack's empty.");
            }
            return stringBox;
        }

        //Obtiene el último valor ingresado a la pila sin eliminarlo.
        public string Peek()
        {
            string stringBox = null;
            if (inicio.NextNode != null)
            {
                work = inicio.NextNode;
                stringBox = work.Date;
            }
            else
            {
                Console.WriteLine("The stack's empty.");
            }
            return stringBox;
        }

        //Recorre la pila.
        public void Transverse()
        {
            work = inicio;

            while (work.NextNode != null)
            {
                work = work.NextNode;
                string date = work.Date;
                Console.WriteLine("[{0}]", date);
            }
        }
    }
}
