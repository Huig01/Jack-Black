using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Jack_Black.classes
{

    public enum Suits
    {
        HEARTS,
        DIAMONDS,
        CLUBS,
        SPADES
    }

    public enum FaceValue
    {
        ACE=1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    
    public class Card
    {

        Suits suit;
        FaceValue faceValue;
        int value;
        //Image img;

        public Suits Suit 
        {
            get 
            { 
                return suit; 
            }
        }

        public int Value
        {
            get
            { return value; }
            set
            {
                if (faceValue == FaceValue.ACE)
                {
                    this.value = value;
                }
            }
                
            
        }

        public Card(Suits suit, FaceValue faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
            switch(faceValue)
            {
                case FaceValue.ACE:
                    this.value = 11;
                    break;
                case FaceValue.TEN:
                case FaceValue.JACK:
                case FaceValue.QUEEN:
                case FaceValue.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)faceValue;
                    break;
            }
        } 
 
        public override string ToString()
        {
            return this.faceValue + "Of" + this.suit;
        }
    }
}
