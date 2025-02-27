Card card = new Card(Rank.Ten, Suit.Diamonds);
Console.WriteLine($"Created card {card.Rank} of {card.Suit}. Face Up: {card.FaceUp}");
card.FlipOver();
Console.WriteLine($"Flipped card over. Face Up: {card.FaceUp}");

Console.WriteLine();

Deck deck = new Deck();
Console.WriteLine("Created new deck:");
PrintDeck(deck);

Console.WriteLine();

deck.Shuffle();
Console.WriteLine("Shuffled the deck:");
PrintDeck(deck);

void PrintDeck(Deck d)
{
    foreach (Card c in d.Cards)
        Console.Write($"{c.Rank} of {c.Suit} | ");
    Console.WriteLine();
}