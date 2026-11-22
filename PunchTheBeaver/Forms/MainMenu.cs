using PunchTheBeaver.Forms;
using PunchTheBeaver.Gameplay;
using PunchTheBeaver.Saves;
using PunchTheBeaver.UI;
using System;
using System.Windows.Forms;

namespace PunchTheBeaver
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            ButtonStyle.ChangeStyle(this);
            PanelStyle.ChangeStyle(this);

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            DifficultPage difficultPage = new DifficultPage();

            this.Hide();

            difficultPage.ShowDialog();

            if (!this.IsDisposed)
            {
                this.Show();
            }
        }


        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadMenu loadMenu = new LoadMenu();

            this.Hide();

            DialogResult result = loadMenu.ShowDialog();


            if (result == DialogResult.Cancel)
            {
                this.Show();
                return;                                         
            }


            if (result == DialogResult.OK)                      
            {
                GameSaveData saveData = SaveManager.LoadGame(loadMenu.SelectedSaveFilePath);

                Difficulty difficulty = new Difficulty();      

                switch (saveData.Difficulty)                   
                {
                    case "Easy":
                        difficulty.Easy();
                        break;

                    case "Normal":
                        difficulty.Normal();
                        break;

                    case "Hard":
                        difficulty.Hard();
                        break;
                }

                Game game = new Game(difficulty);              

                game.PrepareGame();
                game.RestoreGame(saveData); 
                game.RunGame();

                if (!this.IsDisposed)
                {
                    this.Show();
                }         //ОСТАЁТСЯ, НО ТЕПЕРЬ ПОСЛЕ ИГРЫ!
            }




        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            HighScoresPage highScores=new HighScoresPage();

             this.Hide();

            highScores.ShowDialog();

            this.Show();

        }

        private void ExiteButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
