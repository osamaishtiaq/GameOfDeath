using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDeath
{
    public class Player
    {
        public string Name { get; set; }
        
        // All of the Cards player has
        public List<Card> CardsCollection { get; set; }

        // Players health in the current round. Max health is 5. If health reaches 0, player loses
        public int CurrentHealth { get; set; }
        
        // Players current card on the field
        public List<Card> CardsOnField { get; set; }

        // Current cards in the deck for this round
        public List<Card> CardsInDeck { get; set; }
    }
}
