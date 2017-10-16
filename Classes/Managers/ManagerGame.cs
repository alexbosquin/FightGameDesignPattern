using DesignPattern.Classes.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Managers
{
     class ManagerGame 
    {
        private ManagerGame() { }

        private static ManagerGame Instance;

        public static ManagerGame getInstance()
        {

            if (Instance == null)
            {
                Instance = new ManagerGame();
            }

            return Instance;
        }

         public Character instantiateCharacter()
        {

           CharacterCreator charCreator;
           CharacterRyu charRyu = new CharacterRyu();
           charCreator = new CharacterCreator();
           charCreator.construct(charRyu);

            return charRyu.getCharacter();
        }
    }
}
