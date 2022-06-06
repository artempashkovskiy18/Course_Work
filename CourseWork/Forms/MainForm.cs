using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarsForm newForm = new CarsForm();
            newForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomersForm newForm = new CustomersForm();
            newForm.Show();
            Hide();
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
