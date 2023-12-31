using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Battle
    {
        // Start the fight 



        // Warrior1 attacks Warrior 2, Warrior 2 is damaged and health decreases and vice versa 
        // Get Attack result 

        public static void StartFight(Warrior w1, Warrior w2)
        {
            while (true)
            {
                if (GetAttackResult(w1,w2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(w2, w1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior w1, Warrior w2 )
        {
            double war1AttackAmt = w1.Attack();
            double war2BlkAmt = w2.Block();

            double dmgW2 = war1AttackAmt - war2BlkAmt;

            if (dmgW2 > 0)
            {
                w2.Health-= dmgW2;
            }
            else
            {
                dmgW2 = 0;
            }
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", w1.Name, w2.Name, dmgW2);
            Console.WriteLine("{0} Has {1} Health", w2.Name, w2.Health);

            if (w2.Health <= 0)
            {
                Console.WriteLine("{0} Has Died and {1} is Victorius", w2.Name, w1.Name);
                return "Game Over";

            }
            else
            {
                return "Fight Again";
            }

        }


    }
}
