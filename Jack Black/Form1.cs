using Jack_Black.classes;

namespace Jack_Black
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        Card twoOfHearts = new Card(Suits.HEARTS, FaceValue.TWO);
        public Form1()
        {
            InitializeComponent();
            

            Card card = new Card(Suits.HEARTS, FaceValue.ACE);
            System.Diagnostics.Debug.WriteLine("hi");
            System.Diagnostics.Debug.WriteLine(card.ToString());
            Deck deck = new Deck();
            deck.Shuffle();
            System.Diagnostics.Debug.WriteLine(deck.DrawCard().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Button Clicked");   

            // Card drawdCard = deck.DrawCard();
            //Console.WriteLine(drawdCard.ToString());

        }
    }
}
