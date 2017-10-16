using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.State
{
    class God : STATE
    {
        public override void jump()
        {
            Console.WriteLine("GODDESS Jumping");
        }

        public override void walk()
        {
            Console.WriteLine("GODDESS Walking");
        }


    }
}
