
namespace PunchTheBeaver.GameObjects
{
    internal class BobrK:Beaver
    {
        public BobrK()
        {
            visualData = PunchTheBeaver.Properties.Resources.BobrK;
        }
        public override int Score
        {
            get { return 100; }
        }

        public override int SpawnChance
        {
            get { return 1; }
        }
    }
}
