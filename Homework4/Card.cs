/* Joseph Collado

UML
Class: Cards

Fields:
- _rank : Rank
- _suit : Suit
- _faceUp : bool

Properties:
+ Rank : Rank
+ Suit : Suit
+ FaceUp : bool

Methods:
+ Card(rank: Rank, suit: Suit)
+ FlipOver()

*/

public class Card
{
    // Fields
    private Rank _rank;
    private Suit _suit;
    private bool _faceUp;

    // Card Constructor
    public Card(Rank rank, Suit suit)
    {
        _rank = rank;
        _suit = suit;
        _faceUp = false;
    }

    // Properties
    public Rank Rank { get { return _rank; } }
    public Suit Suit { get { return _suit; } }
    public bool FaceUp { get { return _faceUp; } }

    // Methods
    public void FlipOver() => _faceUp = true;
}
