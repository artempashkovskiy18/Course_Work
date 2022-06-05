using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars_Form newForm = new Cars_Form();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers_Form newForm = new Customers_Form();
            newForm.Show();
            this.Hide();
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
