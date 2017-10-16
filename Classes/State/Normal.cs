using System;

namespace DesignPattern.Classes.State
{
    class Normal : STATE
    {
        public  override void jump()
        {
            Console.WriteLine("Normal Jumping");
        }

         public override void walk()
        {
            Console.WriteLine("Normal Walking");
        }
    }
}
