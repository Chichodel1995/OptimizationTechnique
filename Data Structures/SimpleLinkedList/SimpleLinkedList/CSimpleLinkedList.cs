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
        CSimpleNode inicio, end;

        public CSimpleLinkedList()
        {
            inicio = end = null;
        }

        public CSimpleNode Inicio
        {
            get { return this.inicio; }
            set { this.inicio = value; }
        }

        public CSimpleNode End
        {
            get { return this.end; }
            set { this.end = value;  }
        }

        public bool ItsEmpty() //Cumple la función de verificar si la lista se encuentra vacia o no.
        {
            if (inicio == null && end == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertOpposite(string date)// Cumple la función de Insertar un nodo con su tipo de dato.
        {
            CSimpleNode node = new CSimpleNode(date); // Recordar que en esa clase tenemos un constructor que recibe un parámetro de tipo de dato INT.
            if (ItsEmpty() == true)
            {
              /* Almacenamos en dos variables del mismo valor. 
                "inicio", tendrá en valor ingresado por el parámatro del objeto declarado "node".
                "end", no se porque ingresa el mismo valor.  
              */
                inicio = node;
                end = node;
            }
            else
            {
                // Al saber que no está vacio, pasamos alguiente node ingresando el valor "inicio" porque no podemos pasarle un objeto
                node.NextNode = inicio;
            }
            inicio = node;
        }

        public void ShowList()
        {
            if (ItsEmpty() == true)
            {
                MessageBox.Show("22");
            }
        }

    }
}
