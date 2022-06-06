using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void AddToFile()
        {
            using (StreamWriter w = new StreamWriter("cars.txt", true))
            {
                string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                    Brand_TextBox.Text, Release_Year_TextBox.Text, Price_TextBox.Text,
                    Cylinder_Amount_TextBox.Text, Volume_TextBox.Text, Horse_Power_TextBox.Text,
                    Transmission_Type_TextBox.Text, Length_TextBox.Text, Width_TextBox.Text,
                    Height_TextBox.Text, Peculiarities_TextBox.Text, Condition_TextBox.Text);

                w.WriteLine(temp);
            }
        }



        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            if(Brand_TextBox.Text != "" && Release_Year_TextBox.Text != "" && Price_TextBox.Text != "" &&
                    Cylinder_Amount_TextBox.Text != "" && Volume_TextBox.Text != "" && Horse_Power_TextBox.Text != "" &&
                    Transmission_Type_TextBox.Text != "" && Length_TextBox.Text != "" && Width_TextBox.Text != "" &&
                    Height_TextBox.Text != "" && Condition_TextBox.Text != "")
            {
                AddToFile();
                Close();
            }
            else
            {
                MessageBox.Show("поля марки, характеристик, стану та ціни мають бути заповненими");
            }

        }


        private void AddCarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }
    }
}
