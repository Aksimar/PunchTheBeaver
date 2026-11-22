using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PunchTheBeaver.GameObjects
{
    abstract class GameObject
    {
        public readonly int size;

        protected Image visualData;

        public Image VisualData  //<--property == свойство!= метод
        {
            get
            {
                return visualData;
            }
        }

        //public abstract Image GetImage();  

        public abstract int SpawnChance { get; }
    }
}
