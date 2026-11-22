using System;
using System.Collections.Generic;


namespace PunchTheBeaver.Saves
{
    public class GameSaveData
    {
        public string Difficulty { get; set; }

        public int Score { get; set; }

        public int GameTime { get; set; }

        public DateTime SaveTime { get; set; }

        public List<FieldSaveData> Fields { get; set; }

        public GameSaveData()
        {
            Fields = new List<FieldSaveData>();
        }
    }
}
