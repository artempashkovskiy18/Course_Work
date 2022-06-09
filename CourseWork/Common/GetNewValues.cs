using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CourseWork
{
    public static class GetNewValues
    {
        public static string GetNewStringValue()
        {
            return Interaction.InputBox("Введіть значення: ");
        }
        public static int GetNewIntValue()
        {
            string s = Interaction.InputBox("Введіть значення: ");

            if (int.TryParse(s, out int newValue))
            {
                return newValue;
            }

            if (s == "")
            {
                return -1;
            }

            MessageBox.Show("можна вводити тільки число");
            return -1;
        }
    }
}