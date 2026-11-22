

using System;



namespace PunchTheBeaver.Saves
{
    internal class SaveInfo
    {
        public string Difficulty { get; set; }
        public int Score { get; set; }
        public DateTime SaveTime { get; set; }

        public string SaveFilePath { get; set; }

        public SaveInfo(string difficulty, int score, DateTime saveTime, string saveFilePath)
        {
            Difficulty = difficulty;
            Score = score;
            SaveTime = saveTime;
            SaveFilePath = saveFilePath;
        }
    }
}