using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Attacks
{
    class Punch : Attack
    {
        public void execute()
        {
            Console.WriteLine("Punch!!!!");
        }
    }
}
