using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Add_Customer_Form : Form
    {
        public Add_Customer_Form()
        {
            InitializeComponent();
        }
        Customer adding_customer = new Customer();

        private int Check_is_textBox_empty(TextBox textbox)
        {
            if(textbox.Text == "")
            {
                return -1;
            }
            else
            {
                return int.Parse(textbox.Text);
            }
        }
        private void Add_customer_to_file(Customer customer)
        {
            using (StreamWriter w = new StreamWriter("customers.txt", true))
            {
                string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                        customer.required_car.brand,
                        customer.required_car.release_year,
                        customer.required_car.price,
                        customer.required_car.characteristics.engine.cylinder_amount,
                        customer.required_car.characteristics.engine.volume,
                        customer.required_car.characteristics.engine.horse_power,
                        customer.required_car.characteristics.transmission_type,
                        customer.required_car.characteristics.dimensions.length,
                        customer.required_car.characteristics.dimensions.width,
                        customer.required_car.characteristics.dimensions.height,
                        customer.required_car.peculiarities,
                        customer.required_car.condition,
                        customer.contacts,
                        customer.finances);

                w.WriteLine(temp);
            }
        }



        private void Close_Form_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_New_Customer_Button_Click(object sender, EventArgs e)
        {
            adding_customer.required_car.brand = Brand_TextBox.Text;

            adding_customer.required_car.characteristics.engine.cylinder_amount = Check_is_textBox_empty(Cylinder_Amount_TextBox);
            adding_customer.required_car.characteristics.engine.volume = Check_is_textBox_empty(Volume_TextBox);
            adding_customer.required_car.characteristics.engine.horse_power = Check_is_textBox_empty(Horse_Power_TextBox);

            adding_customer.required_car.characteristics.transmission_type = Transmission_Type_TextBox.Text;

            adding_customer.required_car.characteristics.dimensions.length = Check_is_textBox_empty(Length_TextBox);
            adding_customer.required_car.characteristics.dimensions.width = Check_is_textBox_empty(Width_TextBox);
            adding_customer.required_car.characteristics.dimensions.height = Check_is_textBox_empty(Height_TextBox);

            adding_customer.required_car.peculiarities = Peculiarities_TextBox.Text;
            adding_customer.required_car.condition = Condition_TextBox.Text;

            adding_customer.finances = Check_is_textBox_empty(Finances_TextBox);

            if(Contacts_textBox.Text == "")
            {
                MessageBox.Show("поле контактної інформації має бути заповненим");
            }
            else
            {
                adding_customer.contacts = Contacts_textBox.Text;
                Add_customer_to_file(adding_customer);
                this.Close();
            }
        }



        private void Add_Customer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Customers_Form customers_form = new Customers_Form();
            customers_form.Show();
        }

    }
}
