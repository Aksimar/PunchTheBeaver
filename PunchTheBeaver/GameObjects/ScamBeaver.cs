namespace PunchTheBeaver.GameObjects
{
    internal class ScamBeaver:Beaver
    {
        public ScamBeaver()
        {
            visualData = PunchTheBeaver.Properties.Resources.ScamBeaver;
        }
        public override int Score
        {
            get { return -20; }
        }

        public override int SpawnChance
        {
            get { return 15; }
        }

    }
}
