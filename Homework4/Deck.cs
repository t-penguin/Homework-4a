public class Deck
{
    List<Card> cards = new List<Card>();

    //Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                cards.Add(new Card(rank, suit));
    }

    //Implement a property to get Cards
    

    //Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {
        //implementation
    }

    //Shuffle Method
    public void Shuffle()
    {
        //implementation
    }

    //Cut method
    public void Cut(int index)
    {
        //implementation
    }
}

