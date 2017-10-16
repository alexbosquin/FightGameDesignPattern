using System;
using DesignPattern.Classes.State;

namespace DesignPattern.Classes
{
    public class Character 
    {
        private STATE state;
        private string name;

        public Character setState(STATE st)
        {
            state = st;
            return this;
        }

         public Character setName(string value)
        {
            name = value;
            return this;
        }

         public Character build()
        {
            Console.WriteLine("You selected: " + name);
            return this;
        }

        public void walk()
        {
            state.walk();
        }

        public void jump()
        {
            state.jump();
        }

        public void punch()
        {
            state.punch();
        }

        public void comboA()
        {
            state.comboA();
        }

        public void hit()
        {
            state.hit();
        }
    }
}
