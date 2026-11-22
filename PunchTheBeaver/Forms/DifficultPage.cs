using PunchTheBeaver.Gameplay;
using System;
using System.Windows.Forms;
using PunchTheBeaver.UI;



namespace PunchTheBeaver.Forms
{
    public partial class DifficultPage : Form
    {
        public DifficultPage()
        {
            InitializeComponent();

            ButtonStyle.ChangeStyle(this);
            PanelStyle.ChangeStyle(this);
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            Difficulty difficulty = new Difficulty();
            difficulty.Easy();

            Game game = new Game(difficulty);

            game.PrepareGame();

            this.Hide();

            game.RunGame();

            this.Close();
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            Difficulty difficulty = new Difficulty();
            difficulty.Normal();

            Game game = new Game(difficulty);

            game.PrepareGame();

            this.Hide();

            game.RunGame();

            this.Close();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            Difficulty difficulty = new Difficulty();
            difficulty.Hard();

            Game game = new Game(difficulty);

            game.PrepareGame();

            this.Hide();

            game.RunGame();

            this.Close();
        }
    }
}
