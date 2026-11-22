using PunchTheBeaver.Forms;
using PunchTheBeaver.Saves;
using System;
using System.Windows.Forms;
using PunchTheBeaver.HighScores;

namespace PunchTheBeaver.Gameplay

{
    internal class Game
    {
        private GameField gameField;
        private readonly Difficulty gameDifficulty;
        private GameLogic gameLogic;


        public Game(Difficulty selectedDifficulty)
        {
            gameDifficulty = selectedDifficulty;
        }

        public void PrepareGame()
        {
            gameField = new GameField();       

            gameLogic = new GameLogic(gameField.Fields, gameDifficulty);

            gameLogic.ScoreChanged += GameLogic_ScoreChanged;

            gameLogic.TimeChanged += GameLogic_TimeChanged;

            gameLogic.GameOver += GameLogic_GameOver;

            gameField.PauseRequested += GameField_PauseRequested;
        }


        public void RestoreGame(GameSaveData saveData)     
        {
            gameLogic.RestoreState(saveData);             
        }


        public void RunGame()
        {
            gameField.ShowDialog();
        }



        private void GameLogic_GameOver(object sender, EventArgs e)
        {
            gameField.Hide();

            HighScoreManager.AddScore(gameLogic.Score);

            EndGameWindow endGameWindow = new EndGameWindow(gameLogic.Score);

            endGameWindow.ShowDialog();

            gameField.Close();
        }



        private void GameLogic_ScoreChanged(object sender, EventArgs e)
        {
            gameField.UpdateScore(gameLogic.Score);
        }



        private void GameLogic_TimeChanged(object sender, EventArgs e)
        {
            gameField.UpdateTime(gameLogic.TimeText);
        }



        private void GameField_PauseRequested(object sender, EventArgs e)
        {
            gameLogic.PauseTimers();

            Pause_menu pauseMenu = new Pause_menu(this);

            pauseMenu.SaveRequested += PauseMenu_SaveRequested;

            DialogResult result = pauseMenu.ShowDialog();

            if (result == DialogResult.Abort)
            {
                gameField.Close();
                return;
            }

            gameLogic.ResumeTimers();
        }


        private void PauseMenu_SaveRequested(object sender, EventArgs e)
        {
            GameSaveData saveData = gameLogic.CreateSaveData();

            SaveManager.SaveGame(saveData);

            MessageBox.Show("Game saved");
        }



    }
}
