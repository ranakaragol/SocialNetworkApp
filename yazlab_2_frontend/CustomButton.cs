using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
