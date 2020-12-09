using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class TextBoxExControl : TextBox
    {
        public string Placeholder { get; set; } = "";

        public TextBoxExControl()
        {
            GotFocus += TB_Textbox_GotFocus;
            LostFocus += TB_Textbox_LostFocus;
            HandleCreated += TB_Textbox_HandleCreated;
        }

        private void TB_Textbox_HandleCreated(object sender, EventArgs e)
        {
            Text = Placeholder;
        }

        private void TB_Textbox_GotFocus(object sender, EventArgs e)
        {
            Text = "";
        }

        private void TB_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (Text == "")
                Text = Placeholder;
        }
    }
}
