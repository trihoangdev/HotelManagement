using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.ClassFolder
{
    public static class ControlHelper
    {
        public static void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }
        public static bool IsAllControlEmpty(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control.Text == "") return true;
            }
            return false;
        }

        public static bool IsAllTextIsNumber(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                // Kiểm tra nếu Text của TextBox không phải là số thì trả về false
                if (!double.TryParse(control.Text, out _))
                    return false;
            }
            // Nếu tất cả đều là số thì trả về true
            return true;
        }

        public static void ClearDataInControls(List<Control> controls)
        {
            foreach (Control control in controls)
                control.Text = "";
        }

        public static void SetDateTimeNow(List<Guna2DateTimePicker> dts)
        {
            foreach (Guna2DateTimePicker dt in dts)
            {
                dt.Value = DateTime.Now;
            }
        }
    }
}
