using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class CSimpleNode
    {
        //Acá se coloca la información que entrará de la propiedad "Information".
        private string information;

        //Esta variable de referencia se utiliza para a puntar al siguiente nodo.
        private CSimpleNode nextNode = null;

        //Propiedades.
        public string Information { get => information; set => information = value; }
        internal CSimpleNode NextNode { get => nextNode; set => nextNode = value; }
    }
}
