using Jack_Black.classes;

namespace Jack_Black
{
    public partial class Form1 : Form
    {
        Deck dealerDeck = new Deck();
        Hand dealerHand = new Hand(); 
        Player player1 = new Player();

        int punten = 0;
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValue.TWO);
        public Form1()
        {
            InitializeComponent();
            Deck deck = new Deck();
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine(deck.DrawCard().ToString());




        }

        private void button1_Click(object sender, EventArgs e)
        {           
            dealerDeck.Shuffle();
            System.Diagnostics.Debug.WriteLine(dealerDeck.DrawCard().ToString());
            
        }



        private void button2_Click(object sender, EventArgs e)
        {

            //De game start eerst jezelf een kaart dan klokwaard,
            //de Speler dan klokwaard naar jezelf,
            //en daarna pas naar Speler en eindigt met 2 kaarten

            // voor dealer
            dealerHand.AddCard(dealerDeck.DrawCard());
            dealerHand.AddCard(dealerDeck.DrawCard());
            // voor speler
            player1.Addcard(dealerDeck.DrawCard());
            player1.Addcard(dealerDeck.DrawCard());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            player1.Stand();

        }

        private void button4_Click(object sender, EventArgs e)
        {

           

            Card card = new Card(Suits.HEARTS, FaceValue.TWO);

            
            player1.Hit(card);
            
            


            // System.Diagnostics.Debug.WriteLine(player1.Hit(card).ToString());


        }
    }
}
