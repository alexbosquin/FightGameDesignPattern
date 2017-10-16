using System;

namespace DesignPattern.Classes.HUD
{
    public class ObserverLifebar : Observer
    {
        private int amount = 100;

        public void notify()
        {
            hit(10);
            Console.WriteLine("Losing Life");
        }

        private void hit(int value)
        {
           if (amount > 0)
            {
                amount -= value;
            }
        }
    }
}
