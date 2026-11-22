
using System.Xml.Linq;

namespace PunchTheBeaver.Gameplay
{
    internal class Difficulty
    {
        private int spawnSpeed;
        private int lifeTime;
        private double scoreMultiplier;
        private string name;




        public void Easy()
        {
            name = "Easy";

            spawnSpeed = 2000;
            lifeTime = 8000;
            scoreMultiplier = 1;
        }

        public void Normal()
        {
            name = "Normal";

            spawnSpeed = 800;
            lifeTime = 2000;
            scoreMultiplier = 1.5;
        }

        public void Hard()
        {
            name = "Hard";

            spawnSpeed = 500;
            lifeTime = 800;
            scoreMultiplier = 2;
        }

        public int SpawnSpeed
        {
            get { return spawnSpeed; }
        }
        public int LifeTime
        {
            get { return lifeTime; }
        }
        public double ScoreMultiplier
        {
            get { return scoreMultiplier; }
        }
        public string Name
        {
            get { return name; }
        }

    }
}
