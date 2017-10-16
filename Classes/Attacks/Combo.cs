using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Attacks
{
     abstract class Combo : Attack
    {
        protected ArrayList attacks = new ArrayList();

        protected abstract void execute();

        void Attack.execute()
        {
            Console.Write("Combo: ");
            execute();
        }

    }
}
