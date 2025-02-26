public class Card
{
    //Fields, example: Rank rank;
    //check the help documentation for the fields
    private Rank _rank;
    private Suit _suit;
    private bool _faceUp;

    //Card Constructor
    

    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }
    public Rank Rank { get { return _rank; } }
    public Suit Suit { get { return _suit; } }
    public bool FaceUp { get { return _faceUp; } }

    public void FlipOver()
    {
        //implementation 
    }
        
}
