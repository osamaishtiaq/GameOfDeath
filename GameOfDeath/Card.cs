using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDeath
{
    public class Card
    {
        // Name of the card
        public string Name { get; set; }

        //  Health of the card
        public int Health { get; set; }

        // Attack power of the card
        public int Attack { get; set; }
        
        // Cost required to bring the card on Field
        public int Cost { get; set; }

        // Position of the card on the field i.e. 1st, 2nd, 3rd of Total 5 Positions
        public int Position { get; set; }

        // Abilities of the card
        public List<Ability> Abilities { get; set; }

        // Description or story of the card
        public string Lore { get; set; }
    }
}
