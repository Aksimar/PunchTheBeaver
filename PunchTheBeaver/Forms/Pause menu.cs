using PunchTheBeaver.Gameplay;
using PunchTheBeaver.Saves;
using PunchTheBeaver.UI;
using System;
using System.Windows.Forms;

namespace PunchTheBeaver.Forms
{
    public partial class Pause_menu : Form
    {
        public event EventHandler SaveRequested;

        public event EventHandler LoadRequested;

        private readonly Game game;


        public Pause_menu()
        {
            InitializeComponent();

            ButtonStyle.ChangeStyle(this);
            PanelStyle.ChangeStyle(this);

            this.KeyPreview = true;
            this.KeyDown += PauseMenu_KeyDown;
        }

        internal Pause_menu(Game game) : this()     
        {
            this.game = game;                       
        }


        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            LoadMenu loadMenu = new LoadMenu();

            DialogResult result = loadMenu.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            GameSaveData saveData =
                SaveManager.LoadGame(loadMenu.SelectedSaveFilePath);

            game.RestoreGame(saveData);

            this.Close();
        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
        }


        private void ExiteToMenuButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }


        private void ExitFromTheGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void PauseMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



  
    }

}
