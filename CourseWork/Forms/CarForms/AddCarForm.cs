using System;
using System.IO;
using System.Windows.Forms;
using CourseWork.Sevrices;

namespace CourseWork
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private Car addingCar = new Car();
        private ICarService service = new CarService();

        private bool AreRequiredTextBoxesRigthFilled()
        {
            return BrandTextBox.Text != "" && ReleaseYearTextBox.Text != "" && PriceTextBox.Text != "" &&
                   CylinderAmountTextBox.Text != "" && VolumeTextBox.Text != "" && HorsePowerTextBox.Text != "" &&
                   TransmissionTypeTextBox.Text != "" && LengthTextBox.Text != "" && WidthTextBox.Text != "" &&
                   HeightTextBox.Text != "" && ConditionTextBox.Text != "" &&
                   int.TryParse(ReleaseYearTextBox.Text, out int _) &&
                   int.TryParse(PriceTextBox.Text, out int _) && int.TryParse(CylinderAmountTextBox.Text, out int _) &&
                   int.TryParse(VolumeTextBox.Text, out int _) && int.TryParse(HorsePowerTextBox.Text, out int _) &&
                   int.TryParse(LengthTextBox.Text, out int _) && int.TryParse(WidthTextBox.Text, out int _) &&
                   int.TryParse(HeightTextBox.Text, out int _);
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            if(AreRequiredTextBoxesRigthFilled())
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
                
                service.SaveCar(addingCar);
                Close();
            }
            else
            {
                MessageBox.Show("поля марки, характеристик, стану та ціни мають бути заповненими." +
                                " Поля, які потребують чисел, мають бути заповнені тільки числами");
            }

        }

        private void AddCarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }
    }
}
