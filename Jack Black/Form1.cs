using Jack_Black.classes;

namespace Jack_Black
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
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

           
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine(deck.DrawCard().ToString());
            //Card drawdCard = deck.DrawCard();
            //Console.WriteLine(drawdCard.ToString());

        }



        private void button2_Click(object sender, EventArgs e)
        {

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
