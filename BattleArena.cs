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
            Random random = new Random();

            int randomValue = random.Next(2);
            Creature firstCreature = randomValue == 0 ? Hero : Enemy;
            Creature secondCreature = randomValue == 1 ? Hero : Enemy;
            firstCreature.SetTarget(secondCreature);
            secondCreature.SetTarget(firstCreature);
            //драчка
            Console.WriteLine("Пошла ёбка");
            while (true)
            {
                
                firstCreature.Hp -= firstCreature.PoisonDamagePerMove;
                secondCreature.Hp -= firstCreature.PoisonDamagePerMove;
                Console.WriteLine($"ХП ГЕРОЯ: {Hero.Hp}");
                Console.WriteLine($"ХП ПИДАРАСА: {Enemy.Hp}");

                firstCreature.Attack();
                
                if (secondCreature.Hp <= 0) { break; }

                secondCreature.Attack();

                if (firstCreature.Hp <= 0) { break; }

                Thread.Sleep(1000);
                
            }

            return Hero.Hp > 0 ? 1 : 0; 

            //Реализовать пошаговый бой до окончании жизни одного из участников битвы
            //Вернуть 1 в случае победы. 0 - поражение


        }
    }

   
}

