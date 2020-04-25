using System;
using System.Globalization;
using System.Windows.Forms;

namespace SimpleLinkedList
{
    public partial class Form1 : Form
    {
        CSimpleLinkedList listStudent = new CSimpleLinkedList();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listStudent.Add(txtName.Text);
            txtName.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listStudent.Transverse(lstStudent);
        }

        private void btnEmptyList_Click(object sender, EventArgs e)
        {
            listStudent.Empty(lstStudent);
        }

        private void btnItsEmpty_Click(object sender, EventArgs e)
        {
            listStudent.ItsEmpty(lstStudent);
        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 1)
            {
                CSimpleNode theNode = listStudent.SearchNode(lstStudent, txtName.Text);

                if (theNode != null)
                {
                    lstStudent.Items.Add("[" + theNode.Information + "] was found.");
                }
            }
            else
            {
                MessageBox.Show("Please, enter a name.");
            }
          
        }
    }
}
