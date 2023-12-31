using ConsoleApp2;
using System.Collections;
using System.Collections.Generic;

using System;

internal class Program
{
    public static void Main()
    {
        #region LinkedList section 
        LinkedList<Warrior> warriors = new LinkedList<Warrior>();

        #endregion

        Warrior thor = new Warrior(name: "Thor", health : 250, attackMax: 25, blockMax: 15);
        MagicWarrior loki = new MagicWarrior(name: "loki", health: 220, attackMax: 26, blockMax: 12, teleportChance : 30);

        Battle.StartFight(thor, loki);

    }
}
