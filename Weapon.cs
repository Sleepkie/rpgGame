using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLogicProject
{
    public class Weapon
    {

        private int _hitCount = 0;

        private const double _poisonDamage = 10;

        private double _criticalMultiplier = 1.5;

        public double GetDamageValue(double damage, out bool cold)
        {
            double damageValue = damage;
            _hitCount++;
            if (_hitCount % 3 == 0)
            {
                damageValue *= _criticalMultiplier;
            }
            if (_hitCount % 5 == 0)
            {
                cold = true;
            }
            else cold = false;
            
            return damageValue;
        }

    }
}
