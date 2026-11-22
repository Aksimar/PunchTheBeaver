using System.Drawing;
using System.Windows.Forms;

namespace PunchTheBeaver.UI
{
    internal static class PanelStyle
    {
        public static void ChangeStyle(Control father)
        {
            foreach (Control control in father.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = Color.Black;
                }

                if (control.HasChildren)
                {
                    ChangeStyle(control);
                }
            }
        }
    }
}