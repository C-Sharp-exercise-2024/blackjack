public abstract class Attender
{
    protected List<Card> cards;
    protected string name;

    public Attender(String name)
    {
        this.name = name;
        this.cards = new List<Card>();
    }

    public virtual void start(Stock stock)
    {
        for (int i = 0; i < 2; i++)
        {
            Card card = stock.pick();
            this.cards.Add(card);
        }
    }

    public string Name
    {
        get { return name; }
    }

    public void hit(Stock stock)
    {
        Card card = stock.pick();
        this.cards.Add(card);
    }

    public static int calculateStrengthFromList(List<Card> cards)
    {
        int strength = 0;

        bool hasAce = false;
        for(int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            int number = card.Number;
            if (number == 1)
            {
                hasAce = true;
            }
            if (number >= 10)
            {
                number = 10;
            }
            strength += number;
        }

        if (hasAce && strength + 10 <= 21)
        {
            strength += 10;
        }

        if(strength > 21)
        {
            strength = 0;
        }

        return strength;
    }

    public virtual int calculateStrength()
    {
        int strength = calculateStrengthFromList(cards);
        return strength;
    }

    public virtual void display()
    {
        Console.Write(this.name);
        Console.Write(" : ");
        foreach (Card card in cards)
        {
            Console.Write(card);
        }
        Console.WriteLine();
    }

    public abstract void play(Stock stock);
}

