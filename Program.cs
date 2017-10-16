using System;
using DesignPattern.Classes.Managers;
using DesignPattern.Classes;
using DesignPattern.Classes.State;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ryu = ManagerGame.getInstance().instantiateCharacter();

            ryu.walk();
            ryu.jump();
            ryu.punch();
            ryu.comboA();
            ryu.setState(new God());
            ryu.walk();
            ryu.jump();


            Console.ReadLine();
        }
    }
}
