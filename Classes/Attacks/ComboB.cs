using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Attacks
{
    class ComboB : Combo
    {
        protected override void execute()
        {
            if (attacks == null)
            {
                attacks.Add(new Kick());
                attacks.Add(new Special());
            }

            foreach(Attack a in attacks)
            {
                a.execute();
            }
        }
    }
}
