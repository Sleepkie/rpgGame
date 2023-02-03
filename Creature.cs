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

        public bool isPoisoned { get; set; } = false;

        public bool isFreezed { get; set; } = false;


    }
}
