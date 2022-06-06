using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private Car addingCar = new Car();
        private CarService service = new CarService();

        private void AddToFile()
        {
            using (StreamWriter w = new StreamWriter("cars.txt", true))
            {
                string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                    BrandTextBox.Text, ReleaseYearTextBox.Text, PriceTextBox.Text,
                    CylinderAmountTextBox.Text, VolumeTextBox.Text, HorsePowerTextBox.Text,
                    TransmissionTypeTextBox.Text, LengthTextBox.Text, WidthTextBox.Text,
                    HeightTextBox.Text, PeculiaritiesTextBox.Text, ConditionTextBox.Text);

                w.WriteLine(temp);
            }
        }



        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            if(BrandTextBox.Text != "" && ReleaseYearTextBox.Text != "" && PriceTextBox.Text != "" &&
                    CylinderAmountTextBox.Text != "" && VolumeTextBox.Text != "" && HorsePowerTextBox.Text != "" &&
                    TransmissionTypeTextBox.Text != "" && LengthTextBox.Text != "" && WidthTextBox.Text != "" &&
                    HeightTextBox.Text != "" && ConditionTextBox.Text != "")
            {
                addingCar.brand = BrandTextBox.Text;
                addingCar.releaseYear = int.Parse(ReleaseYearTextBox.Text);
                addingCar.characteristics.engine.cylinderAmount = int.Parse(CylinderAmountTextBox.Text);
                addingCar.characteristics.engine.volume = int.Parse(VolumeTextBox.Text);
                addingCar.characteristics.engine.horsePower = int.Parse(HorsePowerTextBox.Text);
                addingCar.characteristics.transmissionType = CylinderAmountTextBox.Text;
                addingCar.characteristics.dimensions.length = int.Parse(LengthTextBox.Text);
                addingCar.characteristics.dimensions.width = int.Parse(WidthTextBox.Text);
                addingCar.characteristics.dimensions.height = int.Parse(HeightTextBox.Text);
                addingCar.peculiarities = PeculiaritiesTextBox.Text;
                addingCar.condition = ConditionTextBox.Text;
                addingCar.price = int.Parse(PriceTextBox.Text);
                
                service.PutOneCarInFile(addingCar);
                Close();
            }
            else
            {
                MessageBox.Show("поля марки, характеристик, стану та ціни мають бути заповненими");
            }

        }


        private void AddCarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }
    }
}
