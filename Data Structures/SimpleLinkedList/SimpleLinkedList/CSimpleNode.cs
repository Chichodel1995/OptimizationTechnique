using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class CSimpleNode
    {
        private string information;
        private CSimpleNode nextNode;
        public CSimpleNode(string info)
        {
            information = info;
            nextNode = null;
        }

        public string Informacion
        {
            get { return this.information; }
        }

        public CSimpleNode NextNode
        {
            get { return this.nextNode; }
            set { this.nextNode = value; }
        }
    }
}
