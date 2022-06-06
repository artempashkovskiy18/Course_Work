using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CourseWork.CarsFileIndexes;
using static CourseWork.CustomersFileIndexes;
using static CourseWork.CustomerService;

namespace CourseWork
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Exit_To_Menu_Button.DialogResult = DialogResult.Abort;
            Add_Customer_Button.DialogResult = DialogResult.Abort;
            Get_suitable_cars_button.DialogResult = DialogResult.Abort;
        }

        List<Customer> customers = new List<Customer>();
        List<Car> cars = new List<Car>();
        List<ListBox> listboxes = new List<ListBox>();
        int selectedIndex = 0;

        private CustomerService customerService = new CustomerService();
        private CarService carService = new CarService();

        private void SaveInfoBeforeClose()
        {
            using (StreamWriter w = new StreamWriter("customers.txt"))
            {
                foreach (Customer element in customers)
                {
                    string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                        element.requiredCar.brand,
                        element.requiredCar.releaseYear,
                        element.requiredCar.price,
                        element.requiredCar.characteristics.engine.cylinderAmount,
                        element.requiredCar.characteristics.engine.volume,
                        element.requiredCar.characteristics.engine.horsePower,
                        element.requiredCar.characteristics.transmissionType,
                        element.requiredCar.characteristics.dimensions.length,
                        element.requiredCar.characteristics.dimensions.width,
                        element.requiredCar.characteristics.dimensions.height,
                        element.requiredCar.peculiarities,
                        element.requiredCar.condition,
                        element.contacts,
                        element.finances);

                    w.WriteLine(temp);
                }
            }
        }
        
        private void PutToListBoxes()
        {
            foreach (ListBox listBox in listboxes)
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
            foreach (ListBox listBox in listboxes)
            {
                listBox.SelectedIndex = index;
            }
            selectedIndex = index;
        }
        private string ChangeIntValue(ListBox listBox)
        {string s = Interaction.InputBox("Введіть значення: ");
            if (int.TryParse(s, out _))
            {
                listBox.Items[selectedIndex] = s;
                return s;
            }
            MessageBox.Show("можна вводити тільки число");
            return listBox.Items[selectedIndex].ToString();
        }
        private string ChangeStringValue(ListBox listBox)
        {
            string s = Interaction.InputBox("Введіть значення: ");
            
            listBox.Items[selectedIndex] = s;
            return s;
        }

        
        
        
        





        private void CustomersForm_Load(object sender, EventArgs e)
        {
            listboxes = GetListBoxes();
            
            customers = customerService.GetALlCustomersFromFile();
            cars = carService.GetALlCarsFromFile();
            
            PutToListBoxes();
        }
        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            customerService.PutAllCustomersInFile(customers);
        }




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
            DialogResult res = MessageBox.Show("ви хочете видалити елемент?",
                                                "Повідомленння",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button1,
                                                MessageBoxOptions.DefaultDesktopOnly);

            if(res == DialogResult.Yes)
            {
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





        private void BrandListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.brand = 
                ChangeStringValue(brandListBox);
        }
        private void ReleaseYearListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.releaseYear = int.Parse(ChangeIntValue(releaseYearListBox));
        }
        private void CylinderAmountListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.engine.cylinderAmount = 
                int.Parse(ChangeIntValue(cylinderAmountListBox));
        }
        private void VolumeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.engine.volume =
                int.Parse(ChangeIntValue(volumeListBox));
        }
        private void HorsePowerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.engine.horsePower =
                int.Parse(ChangeIntValue(horsePowerListBox));
        }
        private void TransmissionTypeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.transmissionType =
                ChangeStringValue(transmissionTypeListBox);
        }
        private void LengthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.dimensions.length =
                int.Parse(ChangeIntValue(lengthListBox));
        }
        private void WidthListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.dimensions.width =
                   int.Parse(ChangeIntValue(widthListBox));
        }
        private void HeightListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.characteristics.dimensions.height =
                 int.Parse(ChangeIntValue(heightListBox));
        }
        private void PeculiaritiesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.peculiarities =
                ChangeStringValue(lengthListBox);
        }
        private void ConditionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].requiredCar.condition =
                ChangeStringValue(conditionListBox);
        }
        private void FinancesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].finances =
                   int.Parse(ChangeIntValue(financesListBox));
        }
        private void ContactsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selectedIndex].contacts =
                   ChangeStringValue(financesListBox);
        }

    }
}
