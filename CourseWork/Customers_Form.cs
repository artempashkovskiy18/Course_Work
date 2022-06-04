using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CourseWork.Car_information;
using static CourseWork.Cars_File_indexes;
using static CourseWork.Customers_File_indexes;

namespace CourseWork
{
    public partial class Customers_Form : Form
    {
        public Customers_Form()
        {
            InitializeComponent();
            Exit_To_Menu_Button.DialogResult = DialogResult.Abort;
            Add_Customer_Button.DialogResult = DialogResult.Abort;
            Get_suitable_cars_button.DialogResult = DialogResult.Abort;
        }

        List<Customer> customers = new List<Customer>();
        List<Car> cars = new List<Car>();
        List<ListBox> listboxes = new List<ListBox>();
        int selected_index = 0;

        private void Save_Info_Before_Close()
        {
            using (StreamWriter w = new StreamWriter("customers.txt"))
            {
                foreach (Customer element in customers)
                {
                    string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                        element.required_car.brand,
                        element.required_car.release_year,
                        element.required_car.price,
                        element.required_car.characteristics.engine.cylinder_amount,
                        element.required_car.characteristics.engine.volume,
                        element.required_car.characteristics.engine.horse_power,
                        element.required_car.characteristics.transmission.transmission_type,
                        element.required_car.characteristics.dimensions.length,
                        element.required_car.characteristics.dimensions.width,
                        element.required_car.characteristics.dimensions.height,
                        element.required_car.peculiarities,
                        element.required_car.condition,
                        element.contacts,
                        element.finances);

                    w.WriteLine(temp);
                }
            }
        }
        private void Get_Customers_From_File()
        {
            foreach (string line in File.ReadLines("customers.txt"))
            {
                List<string> cutomer_info = line.Split(',').ToList();

                Car car = new Car(
                    cutomer_info[brand_id],
                    Convert.ToInt32(cutomer_info[release_year_id]),
                    Convert.ToInt32(cutomer_info[price_id]),
                    Convert.ToInt32(cutomer_info[cylinder_amount_id]),
                    Convert.ToInt32(cutomer_info[volume_id]),
                    Convert.ToInt32(cutomer_info[horse_power_id]),
                    cutomer_info[transmission_type_id],
                    Convert.ToInt32(cutomer_info[length_id]),
                    Convert.ToInt32(cutomer_info[width_id]),
                    Convert.ToInt32(cutomer_info[height_id]),
                    cutomer_info[peculiarities_id],
                    cutomer_info[condition_id]);

                Customer temp = new Customer(cutomer_info[contacts_id], car, Convert.ToInt32(cutomer_info[finances_id]));

                customers.Add(temp);
            }
        }
        private void Get_Cars_From_File()
        {
            foreach (string line in File.ReadLines("cars.txt"))
            {
                List<string> cutomer_info = line.Split(',').ToList();

                Car car = new Car(
                    cutomer_info[brand_id],
                    Convert.ToInt32(cutomer_info[release_year_id]),
                    Convert.ToInt32(cutomer_info[price_id]),
                    Convert.ToInt32(cutomer_info[cylinder_amount_id]),
                    Convert.ToInt32(cutomer_info[volume_id]),
                    Convert.ToInt32(cutomer_info[horse_power_id]),
                    cutomer_info[transmission_type_id],
                    Convert.ToInt32(cutomer_info[length_id]),
                    Convert.ToInt32(cutomer_info[width_id]),
                    Convert.ToInt32(cutomer_info[height_id]),
                    cutomer_info[peculiarities_id],
                    cutomer_info[condition_id]);
                
                cars.Add(car);
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
            foreach (Customer element in customers)
            {
                brand_listBox.Items.Add(element.required_car.brand);
                release_year_listBox.Items.Add(element.required_car.release_year);
                cylinder_amount_listBox.Items.Add(element.required_car.characteristics.engine.cylinder_amount);
                volume_listBox.Items.Add(element.required_car.characteristics.engine.volume);
                horse_power_listBox.Items.Add(element.required_car.characteristics.engine.horse_power);
                transmission_type_listBox.Items.Add(element.required_car.characteristics.transmission.transmission_type);
                length_listBox.Items.Add(element.required_car.characteristics.dimensions.length);
                width_listBox.Items.Add(element.required_car.characteristics.dimensions.width);
                height_listBox.Items.Add(element.required_car.characteristics.dimensions.height);
                peculiarities_listBox.Items.Add(element.required_car.peculiarities);
                condition_listBox.Items.Add(element.required_car.condition);
                finances_listBox.Items.Add(element.finances);
                contacts_listBox.Items.Add(element.contacts);
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
        private void Change_ListBoxes_SelectedIndex(int id)
        {
            foreach (Control c in listboxes)
            {
                ListBox c1 = (ListBox)c;
                c1.SelectedIndex = id;
            }
            selected_index = id;
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
                catch (System.FormatException)
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
        private List<Car> Get_Suitable_Cars()
        {
            List<Car> temp = new List<Car>();
            
            foreach (Car element in cars) //find suitable cars by price
            {
                if (element.price <= customers[selected_index].finances)
                {
                    temp.Add(element);
                }
            }
            
            
            for(int i = 0; i < temp.Count; i++) //delete cars we don't need by other characteristics
            {
                if (temp[i].brand != customers[selected_index].required_car.brand && 
                    customers[selected_index].required_car.brand != "")
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].release_year != customers[selected_index].required_car.release_year && 
                    customers[selected_index].required_car.release_year != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.engine.cylinder_amount != customers[selected_index].required_car.characteristics.engine.cylinder_amount && 
                    customers[selected_index].required_car.characteristics.engine.cylinder_amount != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.engine.volume != customers[selected_index].required_car.characteristics.engine.volume && 
                    customers[selected_index].required_car.characteristics.engine.volume != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.engine.horse_power != customers[selected_index].required_car.characteristics.engine.horse_power && 
                    customers[selected_index].required_car.characteristics.engine.horse_power != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.transmission.transmission_type != customers[selected_index].required_car.characteristics.transmission.transmission_type && 
                    customers[selected_index].required_car.characteristics.transmission.transmission_type != "")
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.dimensions.length != customers[selected_index].required_car.characteristics.dimensions.length && 
                    customers[selected_index].required_car.characteristics.dimensions.length != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.dimensions.width != customers[selected_index].required_car.characteristics.dimensions.width && 
                    customers[selected_index].required_car.characteristics.dimensions.width != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].characteristics.dimensions.height != customers[selected_index].required_car.characteristics.dimensions.height && 
                    customers[selected_index].required_car.characteristics.dimensions.height != -1)
                {
                    temp.RemoveAt(i);
                }
                
                if (temp[i].condition != customers[selected_index].required_car.condition && 
                    customers[selected_index].required_car.condition != "")
                {
                    temp.RemoveAt(i);
                }
            }
            

            return temp;
        }
        
        





        private void Customers_Form_Load(object sender, EventArgs e)
        {
            listboxes = Get_ListBoxes();
            
            Get_Customers_From_File();
            Get_Cars_From_File();
            
            Put_To_ListBoxes();
        }
        private void Customers_Form_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Add_Customer_Button_Click(object sender, EventArgs e)
        {
            Add_Customer_Form add_Customer = new Add_Customer_Form();
            add_Customer.Show();
            this.Close();
        }
        private void Delete_Customer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ви хочете видалити елемент?",
                                                "Повідомленння",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button1,
                                                MessageBoxOptions.DefaultDesktopOnly);

            if(res == DialogResult.Yes)
            {
                customers.RemoveAt(selected_index);

                Put_To_ListBoxes();
            }
        }
        private void Get_suitable_cars_button_Click(object sender, EventArgs e)
        {
            List<Car> suitable_cars = Get_Suitable_Cars();
            

            Cars_Form carsForm = new Cars_Form(false, suitable_cars);
            carsForm.Show();
            this.Close();
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
        private void finances_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(finances_listBox.SelectedIndex);
        }
        private void contacts_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_ListBoxes_SelectedIndex(contacts_listBox.SelectedIndex);
        }





        private void brand_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.brand = 
                Change_value<string>(brand_listBox);
        }
        private void release_year_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.release_year = Convert.ToInt32(Change_value<int>(release_year_listBox));
        }
        private void cylinder_amount_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.engine.cylinder_amount = 
                Convert.ToInt32(Change_value<int>(cylinder_amount_listBox));
        }
        private void volume_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.engine.volume =
                Convert.ToInt32(Change_value<int>(volume_listBox));
        }
        private void horse_power_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.engine.horse_power =
                Convert.ToInt32(Change_value<int>(horse_power_listBox));
        }
        private void transmission_type_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.transmission.transmission_type =
                Change_value<string>(transmission_type_listBox);
        }
        private void length_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.dimensions.length =
                Convert.ToInt32(Change_value<int>(length_listBox));
        }
        private void width_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.dimensions.width =
                   Convert.ToInt32(Change_value<int>(width_listBox));
        }
        private void height_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.characteristics.dimensions.height =
                 Convert.ToInt32(Change_value<int>(height_listBox));
        }
        private void peculiarities_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.peculiarities =
                Change_value<string>(length_listBox);
        }
        private void condition_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].required_car.condition =
                Change_value<string>(condition_listBox);
        }
        private void finances_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].finances =
                   Convert.ToInt32(Change_value<int>(finances_listBox));
        }
        private void contacts_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customers[selected_index].contacts =
                   Change_value<string>(finances_listBox);
        }

    }
}
