

namespace PunchTheBeaver.GameObjects
{
    internal class Bomb : GameObject
    {

        public Bomb()
        {
            visualData = PunchTheBeaver.Properties.Resources.bomb;
        }

        public override int SpawnChance
        {
            get { return 10; }
        }
    }
}
