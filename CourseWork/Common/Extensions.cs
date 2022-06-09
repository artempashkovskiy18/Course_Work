using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CourseWork
{
    public static class Extensions
    {
        public static bool ChangeIntValue(this ListBox listBox, int selectedIndex, out int newValue)
        {
            string s = Interaction.InputBox("Введіть значення: ");
            if (int.TryParse(s, out newValue))
            {
                listBox.Items[selectedIndex] = s;
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
        public static string ChangeStringValue(this ListBox listBox, int selectedIndex)
        {
            string s = Interaction.InputBox("Введіть значення: ");
            
            listBox.Items[selectedIndex] = s;
            return s;
        }
    }
}