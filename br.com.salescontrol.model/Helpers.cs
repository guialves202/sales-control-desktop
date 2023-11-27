using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.salescontrol.model
{
    public class Helpers
    {
        public void ClearScreen(Form screen)
        {
            foreach (Control mainControl in screen.Controls)
            {
                foreach (Control subControl1 in mainControl.Controls)
                {
                    if (subControl1 is TabPage)
                    {
                        foreach (Control subControl2 in subControl1.Controls)
                        {
                            if (subControl2 is TextBox)
                            {
                                (subControl2 as TextBox).Clear();
                            }

                            if (subControl2 is MaskedTextBox)
                            {
                                (subControl2 as MaskedTextBox).Clear();
                            }

                            if (subControl2 is ComboBox)
                            {
                                (subControl2 as ComboBox).Text = "";
                            }
                        }
                    }
                }
            }
        }
    }
}
