using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tea_Factory_Management_System
{
    public partial class Form1 : Form
    {

        private Form2 newForm;
        private Form3 newForm1;
        private Form4 newForm2;
        private Form5 newForm3;

        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            newForm1 = new Form3();
            newForm1.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            newForm2 = new Form4();
            newForm2.Show();
            this.Hide();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            newForm3 = new Form5();
            newForm3.Show();
            this.Hide();
        }
    }
}
