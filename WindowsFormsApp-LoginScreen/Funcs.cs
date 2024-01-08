using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_LoginScreen
{
    internal class Funcs
    {
        public void DisablePanels(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    Panel panel = (Panel)ctrl;

                    panel.Enabled = false;
                }

                if (ctrl.HasChildren)
                {
                    DisablePanels(ctrl);
                }
            }
        }

        public void EnablePanels(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    Panel panel = (Panel)ctrl;

                    panel.Enabled = true;
                }

                if (ctrl.HasChildren)
                {
                    EnablePanels(ctrl);
                }
            }
        }








    }


}
