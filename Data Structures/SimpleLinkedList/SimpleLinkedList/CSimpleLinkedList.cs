using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        CSimpleNode work2;
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

        public void Empty(ListBox pList)
        {
            inicio.NextNode = null;
            pList.Items.Clear();
            pList.Items.Add("The list was emptied.");
            //Al indicar que después del nodo "inicio" sea null, el Gargabe Collector se encargará de liberar la memoria.
            //Si fuera con otro lenguaje como C++, nosotros mismo debemos encargarnos manualmente.
        }

        public bool ItsEmpty(ListBox pList)
        {
            
            pList.Items.Clear();
            if (inicio.NextNode == null)
            {
                pList.Items.Add(true);
                return true;
            }
            else
            {
                pList.Items.Add(false);
                return false;
            }
        }

        public CSimpleNode SearchNode(ListBox pList, string pInfo)
        {
            if (ItsEmpty(pList) == true)
            {
                pList.Items.Clear();
                pList.Items.Add("The list is empty");
                return null;
            }
            else { pList.Items.Clear(); }

            work2 = inicio;

            while (work2.NextNode != null){
                work2 = work2.NextNode;

                if (work2.Information == pInfo)
                {
                    return work2;
                }
            }

            return null;
        }
    }
}
