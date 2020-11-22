using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XComm.Extentions
{
    static class ControlExtention
    {
        public static bool IsNotEmpty(this Control self) 
        {
            switch (self)
            {
                case TextBox textBox:
                    return !textBox.Text.Equals(string.Empty);
                case ComboBox comboBox:
                    return comboBox.SelectedItem != null;
                case CheckBox checkBox:
                    return checkBox.Checked;
                default:
                    return false;
            }
        }
    }
}
