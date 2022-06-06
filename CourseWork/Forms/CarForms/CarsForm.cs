using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CourseWork.Car_information;
using static CourseWork.CarsFileIndexes;

namespace CourseWork
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            ExitToMenuButton.DialogResult = DialogResult.Abort;
            AddCarButton.DialogResult = DialogResult.Abort;
        }
        
        public CarsForm(bool displayAllCars, List<Car> suitable_cars)
        {
            InitializeComponent();
            ExitToMenuButton.DialogResult = DialogResult.Abort;
            AddCarButton.DialogResult = DialogResult.Abort;
            this.displayAllCars = displayAllCars;
            cars = suitable_cars;
        }

        List<Car> cars = new List<Car>();
        List<ListBox> listboxes = new List<ListBox>();
        int selectedIndex = 0;
        private bool displayAllCars = true;


        private void SaveInfoBeforeClose()
        {
            using (StreamWriter w = new StreamWriter("cars.txt"))
            {
                foreach (Car element in cars)
                {
                    string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                        element.brand, 
                        element.release_year,
                        element.price,
                        element.characteristics.engine.cylinder_amount,
                        element.characteristics.engine.volume, 
                        element.characteristics.engine.horse_power,
                        element.characteristics.transmission_type,
                        element.characteristics.dimensions.length,
                        element.characteristics.dimensions.width,
                        element.characteristics.dimensions.height,
                        element.peculiarities, element.condition);
        
                    w.WriteLine(temp);
                }
            }
        }
        private void GetInfoFromFile()
        {
            foreach (string line in File.ReadLines("cars.txt"))
            {
                List<string> carInfo = line.Split(',').ToList();
                Car temp = new Car(carInfo[brand_index],
                    int.Parse(carInfo[release_year_index]),
                    int.Parse(carInfo[price_index]),
                    int.Parse(carInfo[cylinder_amount_index]),
                    int.Parse(carInfo[volume_index]),
                    int.Parse(carInfo[horse_power_index]),
                    carInfo[transmission_type_index],
                    int.Parse(carInfo[length_index]),
                    int.Parse(carInfo[width_index]),
                    int.Parse(carInfo[height_index]),
                    carInfo[peculiarities_index],
                    carInfo[condition_index]);

                cars.Add(temp);
            }
        }
        private void PutToListBoxes()
        {
            //clearing listboxes
            foreach (ListBox listBox in listboxes)
            {
                listBox.Items.Clear();
            }
            //filling listboxes
            foreach (Car car in cars)
            {
                brandListBox.Items.Add(car.brand);
                releaseYearListBox.Items.Add(car.release_year);
                cylinderAmountListBox.Items.Add(car.characteristics.engine.cylinder_amount);
                volumeListBox.Items.Add(car.characteristics.engine.volume);
                horsePowerListBox.Items.Add(car.characteristics.engine.horse_power);
                transmissionTypeListBox.Items.Add(car.characteristics.transmission_type);
                lengthListBox.Items.Add(car.characteristics.dimensions.length);
                widthListBox.Items.Add(car.characteristics.dimensions.width);
                heightListBox.Items.Add(car.characteristics.dimensions.height);
                peculiaritiesListBox.Items.Add(car.peculiarities);
                conditionListBox.Items.Add(car.condition);
                priceListBox.Items.Add(car.price);
            }
        }
        private List<ListBox> GetListBoxes()
        {
            List<ListBox> listboxes = new List<ListBox>();

            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(ListBox))
                {
                    listboxes.Add((ListBox)control);
                }
            }

            return listboxes;
        }
        private void ChangeListBoxesSelectedIndex(int i)
        {
            foreach(ListBox control in listboxes)
            {
                control.SelectedIndex = i;
            }
            selectedIndex = i;
        }
        private string ChangeIntValue(ListBox listBox)
        {
            string s = Interaction.InputBox("Введіть значення: ");
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
        



        private void CarsForm_Load(object sender, EventArgs e)
        {
            listboxes = GetListBoxes();
            
            if (displayAllCars)
            {
                GetInfoFromFile();
            }
            else
            {
                AddCarButton.Enabled = false;
                AddCarButton.Hide();
                DeleteCarButton.Enabled = false;
                DeleteCarButton.Hide();
            }
            
            PutToListBoxes();
        }
        private void CarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (displayAllCars)
            {
                if (DialogResult == DialogResult.None)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                SaveInfoBeforeClose();
            }
            else
            {
                CustomersForm customersForm = new CustomersForm();
                customersForm.Show();
            }
        }






        private void ExitToMenuButton_Click(object sender, EventArgs e)
        {
            if (displayAllCars)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            Close();
        }
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCar = new AddCarForm();
            addCar.Show();
            Close();
        }
        private void DeleteCarButton_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("ви хочете видалити елемент?",
                                                "Повідомленння",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button1,
                                                MessageBoxOptions.DefaultDesktopOnly);
            Show();

            if (res == DialogResult.Yes)
            {
                cars.RemoveAt(selectedIndex);
                PutToListBoxes();
            }
        }






        private void peculiaritiesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                cars[selectedIndex].peculiarities = ChangeStringValue(peculiaritiesListBox);
            }
        }
        private void conditionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                cars[selectedIndex].condition = ChangeStringValue(conditionListBox);
            }
        }
        private void priceListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                cars[selectedIndex].price = int.Parse(ChangeIntValue(priceListBox));
            }
        }






        private void brandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(brandListBox.SelectedIndex);
        }
        private void releaseYearListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(releaseYearListBox.SelectedIndex);
        }
        private void cylinderAmountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(cylinderAmountListBox.SelectedIndex);
        }
        private void volumeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(volumeListBox.SelectedIndex);
        }
        private void horsePowerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(horsePowerListBox.SelectedIndex);
        }
        private void transmissionTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(transmissionTypeListBox.SelectedIndex);
        }
        private void lengthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(lengthListBox.SelectedIndex);
        }
        private void widthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(widthListBox.SelectedIndex);
        }
        private void heightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(heightListBox.SelectedIndex);
        }
        private void peculiaritiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(peculiaritiesListBox.SelectedIndex);
        }
        private void conditionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(conditionListBox.SelectedIndex);
        }
        private void priceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeListBoxesSelectedIndex(priceListBox.SelectedIndex);
        }

    }
}
