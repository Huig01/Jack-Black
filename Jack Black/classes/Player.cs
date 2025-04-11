using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jack_Black.classes
{
    public class Player
    {

        Hand hand = new Hand();

        public void Hit(Card card)
        {
            hand.hit(card);            
        }

        public void Addcard(Card card)
        {
            hand.AddCard(card);
        }
        
        public void Stand()
        {
            hand.Stand();
        }
    }
}
