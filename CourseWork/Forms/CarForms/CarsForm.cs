using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Sevrices;
using static CourseWork.CarsFileIndexes;
using static CourseWork.GetNewValues;

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
        int selectedIndex = 0;
        private bool displayAllCars = true;
        private ICarService service = new CarService();

        //self-made methods
        private void PutToListBoxes()
        {
            foreach (ListBox listBox in GetListBoxes())
            {
                listBox.Items.Clear();
            }

            foreach (Car car in cars)
            {
                brandListBox.Items.Add(car.brand);
                releaseYearListBox.Items.Add(car.releaseYear);
                cylinderAmountListBox.Items.Add(car.characteristics.engine.cylinderAmount);
                volumeListBox.Items.Add(car.characteristics.engine.volume);
                horsePowerListBox.Items.Add(car.characteristics.engine.horsePower);
                transmissionTypeListBox.Items.Add(car.characteristics.transmissionType);
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
            foreach (ListBox control in GetListBoxes())
            {
                control.SelectedIndex = i;
            }

            selectedIndex = i;
        }

        
        //form load and closing methods
        private void CarsForm_Load(object sender, EventArgs e)
        {
            if (displayAllCars)
            {
                cars = service.GetCars();
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
            }
            else
            {
                CustomersForm customersForm = new CustomersForm();
                customersForm.Show();
            }
        }

        
        //buttons click methods
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
                service.DeleteCar(cars[selectedIndex]);
                cars.RemoveAt(selectedIndex);
                PutToListBoxes();
            }
        }

        
        //change car's values methods
        private void peculiaritiesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                string newValue = GetNewStringValue();
                cars[selectedIndex] = service.EditCar(cars[selectedIndex], peculiarities_index, newValue);
                peculiaritiesListBox.Items[selectedIndex] = newValue;
            }
        }
        private void conditionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                string newValue = GetNewStringValue();
                cars[selectedIndex] = service.EditCar(cars[selectedIndex], condition_index, newValue);
                conditionListBox.Items[selectedIndex] = newValue;
            }
        }
        private void priceListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayAllCars)
            {
                int newValue = GetNewIntValue();
                cars[selectedIndex] = service.EditCar(cars[selectedIndex], price_index, newValue.ToString());
                priceListBox.Items[selectedIndex] = newValue;
            }
        }

        
        //change listboxes selected index methods
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