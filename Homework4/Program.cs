// Test creation and flipping of a singular card
Card card = new Card(Rank.Ten, Suit.Diamonds);
Console.WriteLine($"Created card {card.Rank} of {card.Suit}. Face Up: {card.FaceUp}");
card.FlipOver();
Console.WriteLine($"Flipped card over. Face Up: {card.FaceUp}");

Console.WriteLine();

// Test creationg of a deck
Deck deck = new Deck();
Console.WriteLine("Created new deck:");
PrintDeck(deck);

Console.WriteLine();

// Test cutting of a deck
int cutPosition = 25;
deck.Cut(cutPosition);
Console.WriteLine($"Cut the deck at index {cutPosition}");
PrintDeck(deck);

Console.WriteLine();

// Test shuffling of a deck
deck.Shuffle();
Console.WriteLine("Shuffled the deck:");
PrintDeck(deck);

Console.WriteLine();

// Test taking the top card of a deck
card = deck.TakeTopCard();
Console.WriteLine($"Took the top card of the deck: {card.Rank} of {card.Suit}");
Console.WriteLine("The remainder of the deck is:");
PrintDeck(deck);


// Prints the deck from top to bottom
void PrintDeck(Deck d)
{
    foreach (Card c in d.Cards)
        Console.Write($"{c.Rank} of {c.Suit} | ");
    Console.WriteLine();
}