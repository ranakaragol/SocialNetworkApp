using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.CustomWidgets
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }

        private void InitializeComponent()
        {

        }
    }
}
