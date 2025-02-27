Card card = new Card(Rank.Ten, Suit.Diamonds);
Console.WriteLine($"Created card {card.Rank} of {card.Suit}. Face Up: {card.FaceUp}");
card.FlipOver();
Console.WriteLine($"Flipped card over. Face Up: {card.FaceUp}");

