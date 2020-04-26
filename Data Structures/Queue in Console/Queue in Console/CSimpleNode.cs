using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_in_Console
{
    class CSimpleNode
    {
        private int date;
        private CSimpleNode nextNode = null;
        public int Date { get => date; set => date = value; }
        public CSimpleNode NextNode { get => nextNode; set => nextNode = value; }
    }
}
