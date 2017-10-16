using DesignPattern.Classes.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Classes.Characters
{
    class CharacterChunLi : CharacterBuilder
    {
        private Character character;
        public void build()
        {
            character = new Character();
            character.setName("Chun-Li").setState(new Normal()).build();
        }

        public Character getCharacter()
        {
            return character;
        }
    }
}
