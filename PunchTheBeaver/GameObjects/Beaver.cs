
using System.Drawing;

namespace PunchTheBeaver.GameObjects
{
    internal class Beaver:GameObject
    {
        public Beaver()
        {
            visualData = PunchTheBeaver.Properties.Resources.Beaver;
        }
        public virtual int Score
        {
            get { return 10; }
        }

        public override int SpawnChance 
        { 
            get {return 50; }
        }
    }
}
