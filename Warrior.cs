using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Warrior
    {
        public string Name { get; set; }

        public double Health { get; set; }

        public double AttackMax {  get; set; }

        public double BlockMax { get; set;}

        Random random = new Random();

        public Warrior(string name, double health, double attackMax, double blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        
        }


        public double Attack()
        {
            return random.Next(1, (int) AttackMax);
        }

        public virtual double Block()
        {
            return random.Next(1, (int) BlockMax);
        }

    }
}
