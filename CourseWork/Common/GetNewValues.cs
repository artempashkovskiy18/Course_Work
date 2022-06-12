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
        public static bool GetNewIntValue(out int newValue)
        {
            string s = Interaction.InputBox("Введіть значення: ");
            
            if (int.TryParse(s, out newValue))
            {
                return true;
            }
            
            if (s == "")
            {
                newValue = -1;
                return true;
            }
            
            MessageBox.Show("можна вводити тільки число");
            return false;
        }
    }
}