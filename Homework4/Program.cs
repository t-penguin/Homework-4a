Card card = new Card(Rank.Ten, Suit.Diamonds);
Console.WriteLine($"Created card {card.Rank} of {card.Suit}. Face Up: {card.FaceUp}");
card.FlipOver();
Console.WriteLine($"Flipped card over. Face Up: {card.FaceUp}");

Console.WriteLine();

Deck deck = new Deck();
Console.WriteLine("Created new deck: ");
foreach (Card c in deck.Cards)
    Console.Write($"{c.Rank} of {c.Suit}, ");
Console.WriteLine();