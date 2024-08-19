
public class Stock
{
    private List<Card> cards;

    public Stock()
    {
        Random random = new Random();

        this.cards = new List<Card>();
        List<Card> cards = Card.getAllCards();

        while (cards.Count > 0)
        {
            int index = random.Next(0, cards.Count);
            Card card = cards[index];
            this.cards.Add(card);
            cards.Remove(card);
        }
    }

    public Card pick()
    {
        Card card = this.cards[0];
        this.cards.Remove(card);
        return card;
    }

    public int count()
    {
        return this.cards.Count;
    }
}
