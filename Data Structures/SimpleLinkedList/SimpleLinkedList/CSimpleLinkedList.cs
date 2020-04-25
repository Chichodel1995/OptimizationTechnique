using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLinkedList
{
    class CSimpleLinkedList
    {
        //Es el encabezado de la lista.
        CSimpleNode inicio;
        //Esta variable de referiancia nos permite trabajar con la lista.
        CSimpleNode work;
        public CSimpleLinkedList()
        {
            //Instanciamos el inicio.
            inicio = new CSimpleNode();
            //Como es una lista vacia, el siguiente node esta vacío.
            inicio.NextNode = null;
        }

        //Nos permite recorrer de forma secuencial a cada uno de los nodos.
        public void Transverse(ListBox pList)
        {
            pList.Items.Clear();
            work = inicio;
            while (work.NextNode != null)
            {
                work = work.NextNode;
                string info = work.Information;
                pList.Items.Add(info);    
            }            
        }

        //Se ingresa el valor en el último nodo de la lista.
        public void Add(string pInformation)
        {
            //Iniciamos con el valor vacio de inicio.
            work = inicio;

            //Recorremos hasta el final para tener el último valor.
            while(work.NextNode != null)
            {
                work = work.NextNode;
            }
            //Instanciamos una variable de referencia.
            CSimpleNode temporary = new CSimpleNode();
            //Ingresamos el valor ingresado por parámetro.
            temporary.Information = pInformation;

            //Finalizamos correctamente.
            temporary.NextNode = null;

            //Se ingresa el valor al último nodo encontrado con el recién creado.
            work.NextNode = temporary;
        }
    }
}
