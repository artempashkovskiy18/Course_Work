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
                brandListBox.Items.Add(customer.requiredCar.brand);
                releaseYearListBox.Items.Add(customer.requiredCar.releaseYear);
                cylinderAmountListBox.Items.Add(customer.requiredCar.characteristics.engine.cylinderAmount);
                volumeListBox.Items.Add(customer.requiredCar.characteristics.engine.volume);
                horsePowerListBox.Items.Add(customer.requiredCar.characteristics.engine.horsePower);
                transmissionTypeListBox.Items.Add(customer.requiredCar.characteristics.transmissionType);
                lengthListBox.Items.Add(customer.requiredCar.characteristics.dimensions.length);
                widthListBox.Items.Add(customer.requiredCar.characteristics.dimensions.width);
                heightListBox.Items.Add(customer.requiredCar.characteristics.dimensions.height);
                peculiaritiesListBox.Items.Add(customer.requiredCar.peculiarities);
                conditionListBox.Items.Add(customer.requiredCar.condition);
                financesListBox.Items.Add(customer.finances);
                contactsListBox.Items.Add(customer.contacts);
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

        
        //load and closing methods
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
            //customers[selectedIndex].requiredCar.brand =
            //    brandListBox.ChangeStringValue(selectedIndex);

            string newValue = GetNewStringValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], brand_index, newValue);
            brandListBox.Items[selectedIndex] = newValue;
        }
        private void ReleaseYearListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], release_year_index, newValue.ToString());
            releaseYearListBox.Items[selectedIndex] = newValue;
            //if (releaseYearListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.releaseYear = newValue;
            //}
        }
        private void CylinderAmountListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], cylinder_amount_index, newValue.ToString());
            cylinderAmountListBox.Items[selectedIndex] = newValue;
            //if (cylinderAmountListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.engine.cylinderAmount = newValue;
            //}
        }
        private void VolumeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], volume_index, newValue.ToString());
            volumeListBox.Items[selectedIndex] = newValue;
            //if (volumeListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.engine.volume = newValue;
            //}
        }
        private void HorsePowerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], horse_power_index, newValue.ToString());
            horsePowerListBox.Items[selectedIndex] = newValue;
            //if (horsePowerListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.engine.horsePower = newValue;
            //}
        }
        private void TransmissionTypeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], transmission_type_index, newValue);
            transmissionTypeListBox.Items[selectedIndex] = newValue;
            //customers[selectedIndex].requiredCar.characteristics.transmissionType =
            //    transmissionTypeListBox.ChangeStringValue(selectedIndex);
        }
        private void LengthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], length_index, newValue.ToString());
            lengthListBox.Items[selectedIndex] = newValue;
            //if (lengthListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.dimensions.length = newValue;
            //}
        }
        private void WidthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], width_index, newValue.ToString());
            widthListBox.Items[selectedIndex] = newValue;
            //if (widthListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.dimensions.width = newValue;
            //}
        }
        private void HeightListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], height_index, newValue.ToString());
            heightListBox.Items[selectedIndex] = newValue;
            //if (heightListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].requiredCar.characteristics.dimensions.height = newValue;
            //}
        }
        private void PeculiaritiesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], peculiarities_index, newValue);
            peculiaritiesListBox.Items[selectedIndex] = newValue;
            //customers[selectedIndex].requiredCar.peculiarities =
            //    peculiaritiesListBox.ChangeStringValue(selectedIndex);
        }
        private void ConditionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], condition_index, newValue);
            conditionListBox.Items[selectedIndex] = newValue;
            
            //customers[selectedIndex].requiredCar.condition =
            //    conditionListBox.ChangeStringValue(selectedIndex);
        }
        private void FinancesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newValue = GetNewIntValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], finances_index, newValue.ToString());
            financesListBox.Items[selectedIndex] = newValue;
            //if (financesListBox.ChangeIntValue(selectedIndex, out int newValue))
            //{
            //    customers[selectedIndex].finances = newValue;
            //}
        }
        private void ContactsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string newValue = GetNewStringValue();
            customers[selectedIndex] = customerService.EditCustomer(customers[selectedIndex], contacts_index, newValue);
            contactsListBox.Items[selectedIndex] = newValue;
            //customers[selectedIndex].contacts =
            //    financesListBox.ChangeStringValue(selectedIndex);
        }
    }
}