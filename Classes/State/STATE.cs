using DesignPattern.Classes.Attacks;
using DesignPattern.Classes.HUD;

namespace DesignPattern.Classes.State
{
    public abstract class STATE
    {
        private Observer observerLifeBar;
        protected Attack attack;
        public abstract void jump();
        public abstract void walk();
        public void punch()
        {
            attack = new Punch();
            attack.execute();
        }

        public void comboA()
        {
            attack = new ComboA();
            attack.execute();
        }


        public void hit()
        {
            observerLifeBar.notify();
        }

        public void setObserver(Observer o)
        {
            observerLifeBar = o;
        }

    }
}
