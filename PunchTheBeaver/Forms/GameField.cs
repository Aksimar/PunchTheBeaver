using PunchTheBeaver.Gameplay;
using PunchTheBeaver.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PunchTheBeaver.Forms
{
    public partial class GameField : Form
    {

        private readonly List<Field> fields; //fields collection

        public event EventHandler PauseRequested;


        public GameField()
        {
            InitializeComponent();

            PanelStyle.ChangeStyle(this);

            CenterBoardPanel();

            MakeHolesRound(BoardPanel);
            AddHoleBorders(BoardPanel);

            PreparePictureBoxes(BoardPanel);

            fields = new List<Field>();

            for (int i = 1; i <= 9; i++)
            {
                PictureBox pictureBox =
                    Controls.Find($"P_Box{i}", true)[0] as PictureBox;

                fields.Add(new Field(pictureBox));
            }

            this.KeyPreview = true;
            this.KeyDown += GameField_KeyDown;
        }

        internal List<Field> Fields
        {
            get
            {
                return fields;
            }
        }

        //  Border 
        private void MakeHolesRound(Panel board)
        {
            foreach (Control control in board.Controls)
            {
                if (control is Panel hole)
                {
                    GraphicsPath path = new GraphicsPath();

                    path.AddEllipse(
                        0,
                        0,
                        hole.Width,
                        hole.Height
                    );

                    hole.Region = new Region(path);

                    path.Dispose();
                }
            }
        }

        private void CenterBoardPanel()
        {
            BoardPanel.Left = (ClientSize.Width - BoardPanel.Width) / 2;
            BoardPanel.Top = (ClientSize.Height - BoardPanel.Height) / 2;
        }

        private void GameField_Resize(object sender, EventArgs e)
        {
            CenterBoardPanel();
        }

        private void AddHoleBorders(Panel board)
        {
            foreach (Control control in board.Controls)
            {
                if (control is Panel hole)
                {
                    hole.Paint += Hole_Paint;
                }
            }
        }

        private void Hole_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel hole)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                float borderWidth = 5f;
                float offset = borderWidth / 2f;

                using (Pen borderPen = new Pen(Color.Black, borderWidth))
                {
                    e.Graphics.DrawEllipse(
                        borderPen,
                        offset, //отступ от края
                        offset,//отступ от края
                        hole.Width - borderWidth,
                        hole.Height - borderWidth
                    );
                }
            }
        }


        //Picture Box

        private void PreparePictureBoxes(TableLayoutPanel board)
        {
            foreach (Control control in board.Controls)
            {
                if (control is Panel hole)
                {
                    foreach (Control child in hole.Controls)
                    {
                        if (child is PictureBox picture)
                        {
                            picture.Dock = DockStyle.Fill;
                            picture.Margin = Padding.Empty;
                            picture.BorderStyle = BorderStyle.None;
                            picture.BackColor = Color.Transparent;
                            picture.SizeMode = PictureBoxSizeMode.Zoom;

                            GraphicsPath path = new GraphicsPath();

                            path.AddEllipse(
                                0,
                                0,
                                picture.Width,
                                picture.Height
                            );

                            picture.Region = new Region(path);

                            path.Dispose();
                        }
                    }
                }
            }
        }

        public void UpdateScore(int score)
        {
            ScoreLabel.Text = $"Score: {score}";
        }

        public void UpdateTime(string newTime)
        {
            TimeLabel.Text = newTime;
        }

        private void GameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PauseRequested?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

