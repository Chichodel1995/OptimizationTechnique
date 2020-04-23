using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLinkedList
{
    public partial class Form1 : Form
    {
        string name;
        CSimpleLinkedList listStudent = new CSimpleLinkedList();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            listStudent.InsertOpposite(name);
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (listStudent.ItsEmpty() == true)
            {
                lstStudent.Items.Clear();
                lstStudent.Items.Add("Empty list");
            }
            else if (listStudent.Inicio == listStudent.End)
            {
                lstStudent.Items.Clear();
                lstStudent.Items.Add(listStudent.Inicio.Informacion);
            }
            else
            {
                CSimpleNode auxiliaryNode = listStudent.Inicio;
                lstStudent.Items.Clear();
                while (auxiliaryNode != null)
                {
                    lstStudent.Items.Add(auxiliaryNode.Informacion);
                    auxiliaryNode = auxiliaryNode.NextNode;
                }
                lstStudent.Sorted = true;

            }
        }
    }
}
