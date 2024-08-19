public class Card
{
    private Suit suit;
    private int number;

    public Card(Suit suit, int number)
    {
        this.suit = suit;
        this.number = number;
    }

    public int Number
    {
        get { return number; }
    }

    public static string getNumberString(int number)
    {
        string str = "";
        if (number == 1)
        {
            str = "A";
        }
        else if (number == 11)
        {
            str = "J";
        }
        else if (number == 12)
        {
            str = "Q";
        }
        else if (number == 13)
        {
            str = "K";
        }
        else if (number >= 2 && number <= 10)
        {
            str = $"{number}";
        }
        return str;
    }

    public static string getSuitString(Suit suit)
    {
        string str = "";
        if (suit == Suit.Spade)
        {
            str = "スペード";
        }
        else if (suit == Suit.Heart)
        {
            str = "ハート";
        }
        else if (suit == Suit.Diamond)
        {
            str = "ダイヤ";
        }
        else if (suit == Suit.Club)
        {
            str = "クラブ";
        }
        return str;
    }

    public override string ToString()
    {
        string suitString = getSuitString(this.suit);
        string numberString = getNumberString(this.number);
        return $"[{suitString}{numberString}]";
    }

    public static List<Card> getAllCards()
    {
        List<Card> cards = new List<Card>();
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            for (int n = 1; n <= 13; n++)
            {
                Card card = new Card(suit, n);
                cards.Add(card);
            }
        }
        return cards;
    }
}

