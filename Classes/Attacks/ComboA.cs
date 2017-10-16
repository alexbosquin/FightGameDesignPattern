using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Attacks
{
    class ComboA : Combo
    {
        protected override void execute()
        {
                attacks.Add(new Punch());
                attacks.Add(new Kick());

            foreach(Attack a in attacks)
            {
                a.execute();
            }

        }
    }
}
