using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchTheBeaver.Saves
{
    public class FieldSaveData
    {
        public int FieldIndex { get; set; }

        public string ObjectType { get; set; }

        public int RemainingLifeTime { get; set; }


        public FieldSaveData()
        {
        }
    }
}
