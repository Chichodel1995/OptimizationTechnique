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
    }
}
