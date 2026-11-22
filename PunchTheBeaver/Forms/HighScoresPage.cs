using PunchTheBeaver.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PunchTheBeaver.HighScores;

namespace PunchTheBeaver.Forms
{
    public partial class HighScoresPage : Form
    {

        private readonly List<int> highScores;  
           

        public HighScoresPage()
        {
            InitializeComponent();

            ButtonStyle.ChangeStyle(this);
            PanelStyle.ChangeStyle(this);

            highScores = HighScoreManager.GetScores();

            ScorsPanel.Resize += ScorsPanel_Resize;

            ResizeLabelText();

            UpdateScoresTable();

            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void ResizeLabelText()
        {
            float newFontSize = HighScorsLable.Height * 0.2f;



            HighScorsLable.Font = new Font(HighScorsLable.Font.FontFamily, newFontSize, HighScorsLable.Font.Style);

            HighScorsLable.ForeColor = Color.FromArgb(180, 0, 0);
        }

        private void LabelScore_Resize(object sender, EventArgs e)
        {
            ResizeLabelText();
        }





        public void AddScore(int newScore)
        {
            highScores.Add(newScore);

            highScores.Sort();
            highScores.Reverse();

            if (highScores.Count > 10)
            {
                highScores.RemoveAt(highScores.Count - 1);
            }

            UpdateScoresTable();
        }


        private void UpdateScoresTable()
        {
            ScorsPanel.Controls.Clear();
            ScorsPanel.RowStyles.Clear();
            ScorsPanel.RowCount = 10;


            for (int row = 0; row < 10; row++)
            {

                ScorsPanel.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 10F)
                );

            }
                for (int i = 0; i < highScores.Count; i++)
                {
                    Label placeLabel = new Label();

                    placeLabel.Text = $"{i + 1}.";
                    placeLabel.Dock = DockStyle.Fill;
                    placeLabel.Margin = new Padding(0);
                    placeLabel.ForeColor = Color.White;
                    placeLabel.BackColor = Color.Transparent;
                    placeLabel.TextAlign = ContentAlignment.MiddleCenter;


                    Label scoreLabel = new Label();

                    scoreLabel.Text = highScores[i].ToString();
                    scoreLabel.Dock = DockStyle.Fill;
                    scoreLabel.Margin = new Padding(0);
                    scoreLabel.ForeColor = Color.White;
                    scoreLabel.BackColor = Color.Transparent;
                    scoreLabel.TextAlign = ContentAlignment.MiddleCenter;


                    ScorsPanel.Controls.Add(placeLabel, 0, i);
                    ScorsPanel.Controls.Add(scoreLabel, 1, i);
                }

                ResizeScoresText();
            
        }

        private void ResizeScoresText()
        {
            float fontSize = ScorsPanel.ClientSize.Height * 0.025f;

            foreach (Control control in ScorsPanel.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font(
                        HighScorsLable.Font.FontFamily,
                        fontSize,
                        FontStyle.Bold
                    );
                }
            }
        }

        private void ScorsPanel_Resize(object sender, EventArgs e)
        {
            ResizeScoresText();
        }
    }
}

    

