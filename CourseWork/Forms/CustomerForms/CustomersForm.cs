using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Sevrices;
using static CourseWork.CarsFileIndexes;
using static CourseWork.CustomersFileIndexes;
using static CourseWork.GetNewValues;

namespace CourseWork
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Exit_To_Menu_Button.DialogResult = DialogResult.Abort;
            Add_Customer_Button.DialogResult = DialogResult.Abort;
            GetSuitableCarsButton.DialogResult = DialogResult.Abort;
        }

        List<Customer> customers = new List<Customer>();
        List<Car> cars = new List<Car>();
        int selectedIndex = 0;

        private ICustomerService customerService = new CustomerService();
        private ICarService carService = new CarService();

        //self-made methods
        private void PutToListBoxes()
        {
            foreach (ListBox listBox in GetListBoxes())
            {
                listBox.Items.Clear();
            }


            foreach (Customer customer in customers)
            {
                brandListBox.AddElement(customer.requiredCar.brand);
                releaseYearListBox.AddElement(customer.requiredCar.releaseYear);
                cylinderAmountListBox.AddElement(customer.requiredCar.characteristics.engine.cylinderAmount);
                volumeListBox.AddElement(customer.requiredCar.characteristics.engine.volume);
                horsePowerListBox.AddElement(customer.requiredCar.characteristics.engine.horsePower);
                transmissionTypeListBox.AddElement(customer.requiredCar.characteristics.transmissionType);
                lengthListBox.AddElement(customer.requiredCar.characteristics.dimensions.length);
                widthListBox.AddElement(customer.requiredCar.characteristics.dimensions.width);
                heightListBox.AddElement(customer.requiredCar.characteristics.dimensions.height);
                peculiaritiesListBox.AddElement(customer.requiredCar.peculiarities);
                conditionListBox.AddElement(customer.requiredCar.condition);
                financesListBox.AddElement(customer.finances);
                contactsListBox.AddElement(customer.contacts);
            }
        }
        private List<ListBox> GetListBoxes()
        {
            List<ListBox> listBoxes = new List<ListBox>();

            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(ListBox))
                {
                    listBoxes.Add((ListBox)control);
                }
            }

            return listBoxes;
        }
        private void ChangeListBoxesSelectedIndex(int index)
        {
            foreach (ListBox listBox in GetListBoxes())
            {
                listBox.SelectedIndex = index;
            }

            selectedIndex = index;
        }

        
        //form loading and closing methods
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            customers = customerService.GetCustomers();
            cars = carService.GetCars();

            PutToListBoxes();
        }
        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        
        //button click methods
        private void ExitToMenuButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Close();
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Show();
            Close();
        }
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ви хочете видалити елемент?",
                "Повідомленння",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                customerService.DeleteCustomer(customers[selectedIndex]);
                customers.RemoveAt(selectedIndex);
                PutToListBoxes();
            }
        }
        private void GetSuitableCarsButton_Click(object sender, EventArgs e)
        {
            List<Car> suitableCars = customerService.GetSuitableCars(cars, customers[selectedIndex]);

            CarsForm carsForm = new CarsForm(false, suitableCars);
            carsForm.Show();
            Close();
        }

        
        //Change listboxes selected index methods
        private void BrandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(brandListBox.SelectedIndex);
        }
        private void ReleaseYearListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(releaseYearListBox.SelectedIndex);
        }
        private void CylinderAmountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(cylinderAmountListBox.SelectedIndex);
        }
        private void VolumeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(volumeListBox.SelectedIndex);
        }
        private void HorsePowerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(horsePowerListBox.SelectedIndex);
        }
        private void TransmissionTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(transmissionTypeListBox.SelectedIndex);
        }
        private void LengthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(lengthListBox.SelectedIndex);
        }
        private void WidthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(widthListBox.SelectedIndex);
        }
        private void HeightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(heightListBox.SelectedIndex);
        }
        private void PeculiaritiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(peculiaritiesListBox.SelectedIndex);
        }
        private void ConditionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(conditionListBox.SelectedIndex);
        }
        private void FinancesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(financesListBox.SelectedIndex);
        }
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(contactsListBox.SelectedIndex);
        }

        
        //change customer's values methods
        private void BrandListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex].requiredCar.brand = newValue;
            customerService.EditCustomer(customers[selectedIndex]);
            brandListBox.Change(selectedIndex, newValue);
        }
        private void ReleaseYearListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.releaseYear = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                releaseYearListBox.Change(selectedIndex, newValue);
            }
        }
        private void CylinderAmountListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.engine.cylinderAmount = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                cylinderAmountListBox.Change(selectedIndex, newValue);
            }
        }
        private void VolumeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.engine.volume = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                volumeListBox.Change(selectedIndex, newValue);
            }
        }
        private void HorsePowerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.engine.horsePower = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                horsePowerListBox.Change(selectedIndex, newValue);
            }
        }
        private void TransmissionTypeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex].requiredCar.characteristics.transmissionType = newValue;
            customerService.EditCustomer(customers[selectedIndex]);;
            transmissionTypeListBox.Change(selectedIndex, newValue);
        }
        private void LengthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.dimensions.length = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                lengthListBox.Change(selectedIndex, newValue);
            }
        }
        private void WidthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.dimensions.width = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                widthListBox.Change(selectedIndex, newValue);
            }
        }
        private void HeightListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].requiredCar.characteristics.dimensions.height = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                heightListBox.Change(selectedIndex, newValue);
            }
        }
        private void PeculiaritiesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex].requiredCar.peculiarities = newValue;
            customerService.EditCustomer(customers[selectedIndex]);
            peculiaritiesListBox.Change(selectedIndex, newValue);
        }
        private void ConditionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex].requiredCar.condition = newValue;
            customerService.EditCustomer(customers[selectedIndex]);
            conditionListBox.Change(selectedIndex, newValue);
        }
        private void FinancesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetNewIntValue(out int newValue))
            {
                customers[selectedIndex].finances = newValue;
                customerService.EditCustomer(customers[selectedIndex]);
                financesListBox.Change(selectedIndex, newValue);
            }
        }
        private void ContactsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex].contacts = newValue;
            customerService.EditCustomer(customers[selectedIndex]); 
            contactsListBox.Change(selectedIndex, newValue);
        }
    }
}