using PunchTheBeaver.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PunchTheBeaver.Saves;


namespace PunchTheBeaver.Forms
{
   public partial class LoadMenu : Form
    {

        private readonly List<SaveInfo> saves;

        public string SelectedSaveFilePath { get; private set; } //load

        public LoadMenu()
        {
            InitializeComponent();

            SavesTable.Paint += SavesTable_Paint;

            this.Resize += LoadMenu_Resize;

            saves = SaveManager.GetSaveInfo();

            ButtonStyle.ChangeStyle(this);
            PanelStyle.ChangeStyle(this);

            foreach (SaveInfo save in saves)           
            {
                AddSavedRow(save);                      
            }

            UpdateSaveRowsStyle();

        }


    private void SaveRow_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
          

            if (clickedControl == null)
            {
                return;
            }
               

            SaveInfo selectedSave = clickedControl.Tag as SaveInfo;   

            if (selectedSave == null)                                
            {
                return;
            }

            SelectedSaveFilePath = selectedSave.SaveFilePath;        

            this.DialogResult = DialogResult.OK;                      
            this.Close();
        }



        private void AddSavedRow(SaveInfo save)
        {
            
            int row = SavesTable.RowCount;
            SavesTable.RowCount++;


            Label difficultyLabel = new Label();

            difficultyLabel.Text = save.Difficulty;
            difficultyLabel.Margin = new Padding(0);
            difficultyLabel.AutoSize = false;
            difficultyLabel.Dock = DockStyle.Fill;
            difficultyLabel.BackColor = Color.Transparent;
            difficultyLabel.ForeColor = Color.White;
            difficultyLabel.TextAlign = ContentAlignment.MiddleCenter;

            difficultyLabel.Tag = save;
            difficultyLabel.Click += SaveRow_Click;


            Label scoreLabel = new Label();

            scoreLabel.Text = save.Score.ToString();
            scoreLabel.Margin = new Padding(0);
            scoreLabel.AutoSize = false;
            scoreLabel.Dock = DockStyle.Fill;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.ForeColor = Color.White;
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;

            scoreLabel.Tag = save;
            scoreLabel.Click += SaveRow_Click;


            Label timeLabel = new Label();

            timeLabel.Text = save.SaveTime.ToString("dd.MM.yyyy / HH:mm");
            timeLabel.Margin = new Padding(0);
            timeLabel.AutoSize = false;
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.ForeColor = Color.White;
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;

            timeLabel.Tag = save;
            timeLabel.Click += SaveRow_Click;


            SavesTable.Controls.Add(difficultyLabel, 0, row);
            SavesTable.Controls.Add(scoreLabel, 1, row);
            SavesTable.Controls.Add(timeLabel, 2, row);

            UpdateSaveRowsStyle();
        }

        
        private void BackButtonLoadMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void SavesTable_Paint(object sender, PaintEventArgs e)
        {
            int[] rowHeights = SavesTable.GetRowHeights();
            int[] columnWidths = SavesTable.GetColumnWidths();

            int tableWidth = 0;

            foreach (int width in columnWidths)
            {
                tableWidth += width;
            }

            int y = 0;

            using (Pen whitePen = new Pen(Color.White, 1))
            {
                foreach (int rowHeight in rowHeights)
                {
                    e.Graphics.DrawRectangle(
                        whitePen,
                        0,
                        y,
                        tableWidth - 1,
                        rowHeight - 1
                    );

                    y += rowHeight;
                }
            }
        }

        private void LoadMenu_Resize(object sender, EventArgs e)
        {
            UpdateSaveRowsStyle();
        }

        private void UpdateSaveRowsStyle()
        {
            float fontSize;
            float rowHeight;

            if (ClientSize.Height >= 900)
            {
                fontSize = 13F;
                rowHeight = 55F;
            }
            else if (ClientSize.Height >= 700)
            {
                fontSize = 11F;
                rowHeight = 45F;
            }
            else
            {
                fontSize = 9F;
                rowHeight = 35F;
            }


            for (int row = 0; row < SavesTable.RowCount; row++)
            {
                Control firstControl = SavesTable.GetControlFromPosition(0, row);

                if (firstControl == null)
                {
                    continue;
                }


                while (SavesTable.RowStyles.Count <= row)
                {
                    SavesTable.RowStyles.Add(
                        new RowStyle(SizeType.Absolute, rowHeight)
                    );
                }

                SavesTable.RowStyles[row].SizeType = SizeType.Absolute;
                SavesTable.RowStyles[row].Height = rowHeight;


                for (int column = 0; column < SavesTable.ColumnCount; column++)
                {
                    Control control = SavesTable.GetControlFromPosition(column, row);

                    if (control is Label label)
                    {
                        if (label.Font.Size != fontSize)
                        {
                            label.Font = new Font(
                                label.Font.FontFamily,
                                fontSize,
                                label.Font.Style
                            );
                        }
                    }
                }
            }
        }




    }
}
