using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CourseWork.Car_information;
using static CourseWork.Cars_File_indexes;

namespace CourseWork
{
    public partial class Cars_Form : Form
    {
        public Cars_Form()
        {
            InitializeComponent();
            Exit_To_Menu_Button.DialogResult = DialogResult.Abort;
            Add_Car_Button.DialogResult = DialogResult.Abort;
        }

        List<Car> cars = new List<Car>();
        List<ListBox> listboxes = new List<ListBox>();
        int selected_index = 0;


        private void Save_Info_Before_Close()
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
                        element.characteristics.transmission.transmission_type,
                        element.characteristics.dimensions.length,
                        element.characteristics.dimensions.width,
                        element.characteristics.dimensions.height,
                        element.peculiarities, element.condition);
        
                    w.WriteLine(temp);
                }
            }
        }
        private void Get_Info_From_File()
        {
            foreach (string line in File.ReadLines("cars.txt"))
            {
                List<string> car_info = line.Split(',').ToList();
                Car temp = new Car(car_info[brand_id],
                    Convert.ToInt32(car_info[release_year_id]),
                    Convert.ToInt32(car_info[price_id]),
                    Convert.ToInt32(car_info[cylinder_amount_id]),
                    Convert.ToInt32(car_info[volume_id]),
                    Convert.ToInt32(car_info[horse_power_id]),
                    car_info[transmission_type_id],
                    Convert.ToInt32(car_info[length_id]),
                    Convert.ToInt32(car_info[width_id]),
                    Convert.ToInt32(car_info[height_id]),
                    car_info[peculiarities_id],
                    car_info[condition_id]);

                cars.Add(temp);
            }
        }
        private void Put_To_ListBoxes()
        {
            //clearing listboxes
            foreach (ListBox element in listboxes)
            {
                element.Items.Clear();
            }
            //filling listboxes
            foreach (Car element in cars)
            {
                brand_listBox.Items.Add(element.brand);
                release_year_listBox.Items.Add(element.release_year);
                cylinder_amount_listBox.Items.Add(element.characteristics.engine.cylinder_amount);
                volume_listBox.Items.Add(element.characteristics.engine.volume);
                horse_power_listBox.Items.Add(element.characteristics.engine.horse_power);
                transmission_type_listBox.Items.Add(element.characteristics.transmission.transmission_type);
                length_listBox.Items.Add(element.characteristics.dimensions.length);
                width_listBox.Items.Add(element.characteristics.dimensions.width);
                height_listBox.Items.Add(element.characteristics.dimensions.height);
                peculiarities_listBox.Items.Add(element.peculiarities);
                condition_listBox.Items.Add(element.condition);
                price_listBox.Items.Add(element.price);
            }
        }
        private List<ListBox> Get_ListBoxes()
        {
            Control[] x = new Control[Controls.Count];
            Controls.CopyTo(x, 0);
            List<Control> y = x.ToList();
            List<ListBox> listboxes = new List<ListBox>();

            foreach (Control element in y)
            {
                if (element.GetType().ToString() == "System.Windows.Forms.ListBox")
                {
                    listboxes.Add((ListBox)element);
                }
            }

            return listboxes;
        }
        private void Change_ListBoxes_SelectedIndex(int i)
        {
            foreach(Control c in listboxes)
            {
                ListBox c1 = (ListBox)c;
                c1.SelectedIndex = i;
            }
            selected_index = i;
        }
        private string Change_value<T>(ListBox listBox)
        {
            string s = Interaction.InputBox("Введіть значення: ");
            if (typeof(T) == typeof(int))
            {
                try
                {
                    int temp = Convert.ToInt32(s);
                    listBox.Items[selected_index] = s;
                    return s;
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("можна вводити тільки число");
                    return listBox.Items[selected_index].ToString();
                }
            }
            else
            {
                listBox.Items[selected_index] = s;
                return s;
            }
        }



        private void Cars_Form_Load(object sender, EventArgs e)
        {
            listboxes = Get_ListBoxes();
            Get_Info_From_File();
            Put_To_ListBoxes();
        }
        private void Cars_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                Main_form main_form = new Main_form();
                main_form.Show();
            }
            Save_Info_Before_Close();
        }






        private void Exit_To_Menu_Button_Click(object sender, EventArgs e)
        {
            Main_form main_form = new Main_form();
            main_form.Show();
            this.Close();
        }
        private void Add_Car_Button_Click(object sender, EventArgs e)
        {
            Add_Car_Form add_Car = new Add_Car_Form();
             add_Car.Show();
            this.Close();
        }
        private void Delete_Car_Button_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("ви хочете видалити елемент?",
                                                "Повідомленння",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button1,
                                                MessageBoxOptions.DefaultDesktopOnly);
            this.Show();

            if (res == DialogResult.Yes)
            {
                cars.RemoveAt(selected_index);
                Put_To_ListBoxes();
            }
        }






        private void peculiarities_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cars[selected_index].peculiarities = Change_value<string>(peculiarities_listBox);
        }
        private void condition_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cars[selected_index].condition = Change_value<string>(condition_listBox);
        }
        private void price_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cars[selected_index].price = Convert.ToInt32(Change_value<int>(price_listBox));
        }






        private void brand_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(brand_listBox.SelectedIndex);
        }
        private void release_year_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(release_year_listBox.SelectedIndex);
        }
        private void cylinder_amount_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(cylinder_amount_listBox.SelectedIndex);
        }
        private void volume_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(volume_listBox.SelectedIndex);
        }
        private void horse_power_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(horse_power_listBox.SelectedIndex);
        }
        private void transmission_type_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(transmission_type_listBox.SelectedIndex);
        }
        private void length_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(length_listBox.SelectedIndex);
        }
        private void width_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(width_listBox.SelectedIndex);
        }
        private void height_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(height_listBox.SelectedIndex);
        }
        private void peculiarities_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(peculiarities_listBox.SelectedIndex);
        }
        private void condition_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(condition_listBox.SelectedIndex);
        }
        private void price_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(price_listBox.SelectedIndex);
        }

    }
}
