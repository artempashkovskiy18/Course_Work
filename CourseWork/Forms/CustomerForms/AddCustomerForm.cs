using System;
using System.Windows.Forms;
using CourseWork.Sevrices;

namespace CourseWork
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        Customer addingCustomer = new Customer();
        private ICustomerService service = new CustomerService();

        private int CheckIsTextBoxEmptyAndRightFilled(TextBox textBox)
        {
            if(textBox.Text == "" || !int.TryParse(textBox.Text, out int _))
            {
                return -1;
            }
            
            return int.Parse(textBox.Text);
            
        }


        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            
            addingCustomer.requiredCar.brand = BrandTextBox.Text;
            addingCustomer.requiredCar.releaseYear = CheckIsTextBoxEmptyAndRightFilled(ReleaseYearTextBox);

            addingCustomer.requiredCar.characteristics.engine.cylinderAmount = CheckIsTextBoxEmptyAndRightFilled(CylinderAmountTextBox);
            addingCustomer.requiredCar.characteristics.engine.volume = CheckIsTextBoxEmptyAndRightFilled(VolumeTextBox);
            addingCustomer.requiredCar.characteristics.engine.horsePower = CheckIsTextBoxEmptyAndRightFilled(HorsePowerTextBox);

            addingCustomer.requiredCar.characteristics.transmissionType = TransmissionTypeTextBox.Text;

            addingCustomer.requiredCar.characteristics.dimensions.length = CheckIsTextBoxEmptyAndRightFilled(LengthTextBox);
            addingCustomer.requiredCar.characteristics.dimensions.width = CheckIsTextBoxEmptyAndRightFilled(WidthTextBox);
            addingCustomer.requiredCar.characteristics.dimensions.height = CheckIsTextBoxEmptyAndRightFilled(HeightTextBox);

            addingCustomer.requiredCar.peculiarities = PeculiaritiesTextBox.Text;
            addingCustomer.requiredCar.condition = ConditionTextBox.Text;

            addingCustomer.finances = CheckIsTextBoxEmptyAndRightFilled(FinancesTextBox);

            if(ContactsTextBox.Text == "")
            {
                MessageBox.Show("поле контактної інформації має бути заповненим");
            }
            else
            {
                addingCustomer.contacts = ContactsTextBox.Text;
                service.SaveCustomer(addingCustomer);
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
