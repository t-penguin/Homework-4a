﻿public class Deck
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
    List<Card> Cards { get { return _cards; } }

    // Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {
        if (_cards.Count == 0)
            return null;
        
        int lastIndex = _cards.Count - 1;
        Card topCard = _cards[lastIndex];
        _cards.RemoveAt(lastIndex);
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

    //Cut method
    public void Cut(int index)
    {
        //implementation
    }
}

