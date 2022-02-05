using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THING.GAME
{
    public class Player
    {
        public string Name;
        public Deck Deck = new();

        public Player (string lastName)
        {
            Name = lastName;
        }
    }
}
