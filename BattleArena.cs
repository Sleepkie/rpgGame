using System;
namespace RpgLogicProject
{
    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }

        public BattleArena(Enemy enemy, Hero hero)
        {
            Enemy = enemy;
            Hero = hero;
        }


        public int Battle()
        {
            Random random= new Random();
            if (random.Next(2) == 0)
            {



            }
            else
            {

            }

            //Реализовать пошаговый бой до окончании жизни одного из участников битвы
            //Вернуть 1 в случае победы. 0 - поражение

            return 0;
        }
    }

   
}

