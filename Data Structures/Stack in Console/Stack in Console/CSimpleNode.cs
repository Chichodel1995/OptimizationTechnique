using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_in_Console
{
    class CSimpleNode
    {
        private string date;
        private CSimpleNode nextNode = null;

        public string Date { get => date; set => this.date = value; }
        public CSimpleNode NextNode { get => nextNode; set => this.nextNode = value; }
    }
}
