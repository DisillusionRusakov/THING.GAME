using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THING.GAME
{
    public class Card
    {
        public string Name;
        public bool Panic;

        public Card(string lastName, bool panic)

        {
            Name = lastName;
            Panic = panic;
        }

        

    }
}
