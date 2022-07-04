using System.Windows.Forms;

namespace CourseWork
{
    public static class Extensions
    {
        public static void AddElement(this ListBox listBox, string newValue)
        {
            listBox.Items.Add(newValue);
        }
        public static void AddElement(this ListBox listBox, int newValue)
        {
            if (newValue == -1)
            {
                listBox.Items.Add("");
            }
            else
            {
                listBox.Items.Add(newValue);
            }
        }

        public static void Change(this ListBox listBox, int index, string newValue)
        {
            listBox.Items[index] = newValue;
        }
        
        public static void Change(this ListBox listBox, int index, int newValue)
        {
            if (newValue == -1)
            {
                listBox.Items[index] = "";
            }
            else
            {
                listBox.Items[index] = newValue;
            }
        }
    }
}