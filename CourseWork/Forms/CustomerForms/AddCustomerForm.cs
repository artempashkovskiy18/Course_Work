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
        private CustomerService service = new CustomerService();

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
        


        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            addingCustomer.requiredCar.brand = BrandTextBox.Text;

            addingCustomer.requiredCar.characteristics.engine.cylinderAmount = CheckIsTextBoxEmpty(CylinderAmountTextBox);
            addingCustomer.requiredCar.characteristics.engine.volume = CheckIsTextBoxEmpty(VolumeTextBox);
            addingCustomer.requiredCar.characteristics.engine.horsePower = CheckIsTextBoxEmpty(HorsePowerTextBox);

            addingCustomer.requiredCar.characteristics.transmissionType = TransmissionTypeTextBox.Text;

            addingCustomer.requiredCar.characteristics.dimensions.length = CheckIsTextBoxEmpty(LengthTextBox);
            addingCustomer.requiredCar.characteristics.dimensions.width = CheckIsTextBoxEmpty(WidthTextBox);
            addingCustomer.requiredCar.characteristics.dimensions.height = CheckIsTextBoxEmpty(HeightTextBox);

            addingCustomer.requiredCar.peculiarities = PeculiaritiesTextBox.Text;
            addingCustomer.requiredCar.condition = ConditionTextBox.Text;

            addingCustomer.finances = CheckIsTextBoxEmpty(FinancesTextBox);

            if(ContactsTextBox.Text == "")
            {
                MessageBox.Show("поле контактної інформації має бути заповненим");
            }
            else
            {
                addingCustomer.contacts = ContactsTextBox.Text;
                service.PutOneCustomerInFile(addingCustomer);
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
