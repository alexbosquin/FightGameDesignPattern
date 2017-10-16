using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Attacks
{
    class Special : Attack
    {
        public void execute()
        {
            Console.WriteLine("SPECIAL!!!");
        }
    }
}
