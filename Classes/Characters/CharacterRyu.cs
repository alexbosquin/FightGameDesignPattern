using DesignPattern.Classes.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Characters
{
    class CharacterRyu : CharacterBuilder
    {
        private Character character;
        public void build()
        {
            character = new Character();
            character.setName("ryu").setState(new Normal()).build();
        }

        public Character getCharacter()
        {
            return character;
        }
    }
}
