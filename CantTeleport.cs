using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CantTeleport : ITeleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
