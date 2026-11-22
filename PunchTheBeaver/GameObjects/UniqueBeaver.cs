namespace PunchTheBeaver.GameObjects
{
    internal class UniqueBeaver: Beaver
    {
        public UniqueBeaver()
        {
            visualData = PunchTheBeaver.Properties.Resources.UBeaver;
        }
        public override int Score
        {
            get { return 40; }
        }

        public override int SpawnChance
        {
            get { return 10; }
        }
    }
}
