using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_Black.classes
{

    
    public class Deck
    {
        List<Card> deck = new List<Card>(52);
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Card((Suits)i, (FaceValue)j));
                    //shoe.AddRange(new Deck().deck);
                }
            }         
        }
        public void Shuffle()
        {
            if(deck.Count == 0)
            {
                throw new Exception("Deck is empty");
            }

            Random rand = new Random();
            for (int i = 0; i < deck.Count; i++)
            {
                int r = rand.Next(i, deck.Count);
                Card temp = deck[i];
                deck[i] = deck[r];
                deck[r] = temp;
            }
        }

        public Card DrawCard()
        {
            if (deck.Count == 0)
            {
                throw new Exception("Deck is empty");
            }
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

    }
}
