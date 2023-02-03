using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLogicProject
{
    public class Creature
    {
        //Свойства существа 
        public string Name { get; set; }
        public int Level { get; set; }
        public double Hp { get; set; }

        public virtual double Damage { get;  set; }

        //дебаффы

        private bool isPoisoned = false;
        public bool IsPoisoned
        {
            get
            {
                return isPoisoned;
            }
            set { isPoisoned =value;}
        }

        private bool isFreezed = false;
        public bool IsFreezed
        {
            get { return isFreezed; }

            set { isFreezed =value; }



    }
}
