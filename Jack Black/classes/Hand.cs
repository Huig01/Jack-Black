namespace Jack_Black.classes
{
    public class Hand
    {
        bool isBust;
        bool hasStand;
        List<Card> cards = new List<Card>();

        public Hand()
        {
            cards.Add(new Card(Suits.DIAMONDS, FaceValue.KING));
            cards.Add(new Card(Suits.CLUBS, FaceValue.KING));
        }
        //om te testen later verwijderen.
                        


        public void addCard(Card card)
        {
            if(isBust || hasStand || this.cards.Count < 2)
            {
                return;
            }

            cards.Add(card);

            int total = checkTotal();
            if(total > 21)
            {
                isBust = true;
            }else if(total == 21)
            {
                hasStand = true;
            }
        }

        public int checkTotal()
        {
            int total = 0;
            for(int i = 0; i < cards.Count; i++)
            {
                total += cards[i].Value;

            }

            return total;

            //hier onderbreek een funtie
        }

        public void Stand()
        {
            if(isBust || hasStand || this.cards.Count < 2)
            {
                return;
            }

            hasStand = true;
        }
        

    }
}