using PunchTheBeaver.UI;
using System;
using System.Drawing;
using PunchTheBeaver.Properties;
using System.Windows.Forms;


namespace PunchTheBeaver.Forms
{
    public partial class EndGameWindow : Form
    {

        //private Image visualData = Properties.Resources.endGamePicture;

      

        public EndGameWindow(int finalScore)
        {
            InitializeComponent();

            ResizeLabelText();

            EndGamePict.Image = Properties.Resources.endGamePicture;

            ButtonStyle.ChangeStyle(this);

            PanelStyle.ChangeStyle(this);

            LabelScore.Text = $"YOUR SCORE: {finalScore}";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResizeLabelText()
        {
            float newFontSize = LabelScore.Height * 0.2f;

            

            LabelScore.Font = new Font(LabelScore.Font.FontFamily, newFontSize, LabelScore.Font.Style);

            LabelScore.ForeColor = Color.FromArgb(180, 0, 0);
        }

        private void LabelScore_Resize(object sender, EventArgs e)
        {
            ResizeLabelText();
        }

        
    }
}
