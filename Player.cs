public class Player : Attender
{
    public static int ACTION_HIT = 1;
    public static int ACTION_STAND = 2;

    public Player() : base("Player")
    {
    }

    public override int calculateStrength()
    {
        int strength = base.calculateStrength();
        if (strength == 0)
        {
            strength = -1;
        }
        return strength;
    }

    private int selectAction()
    {
        Console.Write(
            $"[{ACTION_HIT}] Hit (カードを引く), "
        );
        Console.Write(
            $"[{ACTION_STAND}] Stand (勝負をする), "
        );
        Console.WriteLine();

        int action = 0;
        while (action != ACTION_HIT && action != ACTION_STAND)
        {
            string? value = Console.ReadLine();
            int.TryParse(value, out action);
        }

        return action;
    }

    public override void play(Stock stock)
    {
        bool standing = false;
        while (!standing)
        {
            this.display();
            int action = this.selectAction();
            if (action == ACTION_HIT)
            {
                this.hit(stock);
                int strength = this.calculateStrength();
                if (strength <= 0)
                {
                    standing = true;
                }
            }
            else
            {
                standing = true;
            }
        }
    }
}


