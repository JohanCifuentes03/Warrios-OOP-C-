using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport CanTeleport = new CanTeleport();

        public MagicWarrior(string name = "Warrior",
                            double health = 0,
                            double attackMax = 0,
                            double blockMax = 0,
                            int teleportChance = 0) : base(name, health, attackMax, blockMax)
        {

            this.teleportChance = teleportChance;
        }

        public override double Block()
        {
            Random random = new Random();
            int rndDodge = random.Next(1, 100);
            if (rndDodge < this.teleportChance)
            {
                Console.WriteLine($"{Name} {CanTeleport.teleport()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }
            
        }
    }
}
