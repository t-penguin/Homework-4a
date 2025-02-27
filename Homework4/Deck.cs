public class Deck
{
    // Fields
    List<Card> _cards = new List<Card>();

    // Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                _cards.Add(new Card(rank, suit));
    }

    // Properties
    public List<Card> Cards { get { return _cards; } }

    // Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {
        if (_cards.Count == 0)
            return null;
        
        Card topCard = _cards.First();
        _cards.RemoveAt(0);
        return topCard;
    }

    // Shuffles the deck
    public void Shuffle()
    {
        Random rand = new Random();
        for (int i = 0; i < Cards.Count; i++)
        {
            int r = rand.Next(i, Cards.Count);
            Card temp = Cards[i];
            Cards[i] = Cards[r];
            Cards[r] = temp;
        }
    }

    // Cuts the deck at the specified index
    public void Cut(int index)
    {
        List<Card> temp = _cards.GetRange(0, index + 1);
        _cards.RemoveRange(0, index + 1);
        _cards.AddRange(temp);
    }
}

