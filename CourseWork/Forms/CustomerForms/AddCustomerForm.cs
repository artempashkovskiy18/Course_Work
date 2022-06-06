using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        Customer addingCustomer = new Customer();

        private int CheckIsTextBoxEmpty(TextBox textBox)
        {
            if(textBox.Text == "")
            {
                return -1;
            }
            else
            {
                return int.Parse(textBox.Text);
            }
        }
        private void AddCustomerToFile(Customer customer)
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



        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            addingCustomer.required_car.brand = BrandTextBox.Text;

            addingCustomer.required_car.characteristics.engine.cylinder_amount = CheckIsTextBoxEmpty(CylinderAmountTextBox);
            addingCustomer.required_car.characteristics.engine.volume = CheckIsTextBoxEmpty(VolumeTextBox);
            addingCustomer.required_car.characteristics.engine.horse_power = CheckIsTextBoxEmpty(HorsePowerTextBox);

            addingCustomer.required_car.characteristics.transmission_type = TransmissionTypeTextBox.Text;

            addingCustomer.required_car.characteristics.dimensions.length = CheckIsTextBoxEmpty(LengthTextBox);
            addingCustomer.required_car.characteristics.dimensions.width = CheckIsTextBoxEmpty(WidthTextBox);
            addingCustomer.required_car.characteristics.dimensions.height = CheckIsTextBoxEmpty(HeightTextBox);

            addingCustomer.required_car.peculiarities = PeculiaritiesTextBox.Text;
            addingCustomer.required_car.condition = ConditionTextBox.Text;

            addingCustomer.finances = CheckIsTextBoxEmpty(FinancesTextBox);

            if(ContactsTextBox.Text == "")
            {
                MessageBox.Show("поле контактної інформації має бути заповненим");
            }
            else
            {
                addingCustomer.contacts = ContactsTextBox.Text;
                AddCustomerToFile(addingCustomer);
                Close();
            }
        }



        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

    }
}
