using System;
using System.Drawing;
using System.Windows.Forms;

namespace PunchTheBeaver.UI
{
    internal static class ButtonStyle
    {
        public static void ChangeStyle(Control father)
        {
            foreach (Control control in father.Controls)
            {
                if (control is Button button)
                {
                    StyleButton(button);
                }

                if (control.HasChildren)
                {
                    ChangeStyle(control);
                }
            }
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;

            button.Size = new Size(400, 150);

            button.Font = new Font(
                "Showcard Gothic",
                20.25F,
                FontStyle.Bold
            );

            button.BackColor = Color.Black;
            button.ForeColor = Color.White;

            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.White;

            
            button.FlatAppearance.MouseDownBackColor = Color.White;

            button.UseVisualStyleBackColor = false;

            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;


        }



        private static void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.Red;
                button.FlatAppearance.BorderColor = Color.Red;
                button.FlatAppearance.BorderSize = 5;
            }
        }

        private static void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.White;
                button.FlatAppearance.BorderSize = 2;
            }
        }



    }
}
