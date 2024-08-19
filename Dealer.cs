public class Dealer : Attender
{
    private bool opened;

    public Dealer() : base("Dealer")
    {
        this.opened = false;
    }

    public override void start(Stock stock)
    {
        base.start(stock);
        this.opened = false;
    }

    public override void display()
    {
        if (this.opened)
        {
            base.display();
        }
        else
        {
            Console.Write(this.name);
            Console.Write(" : ");
            for (int i = 0; i < this.cards.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.cards[i]);
                }
                else
                {
                    Console.Write("[###]");
                }
            }
            Console.WriteLine();
        }
    }

    public override void play(Stock stock)
    {
        int strength = this.calculateStrength();
        while (strength < 17 && strength > 0)
        {
            this.hit(stock);
            strength = this.calculateStrength();
        }
        this.opened = true;
    }
}
