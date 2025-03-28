using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack_Black.classes
{
    public class Player
    {

        Hand hand = new Hand();

        public void Hit(Card card)
        {
            hand.addCard(card);            
        }       
    }
}
