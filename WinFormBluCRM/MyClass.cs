using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBluCRM
{
    public class MyClass
    {
        private Button _button;

        public MyClass(Button button)
        {
            _button = button;
            _button.Click += _button_Click;
        }

        private void _button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event handled by my class");
        }
    }
}
