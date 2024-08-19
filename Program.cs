Player player = new Player();
Dealer dealer = new Dealer();
Stock stock = new Stock();

player.start(stock);
dealer.start(stock);

dealer.display();

player.play(stock);
dealer.play(stock);

showResult(player, dealer);


void showResult(Player player, Dealer dealer)
{
    dealer.display();
    player.display();

    int playerStrength = player.calculateStrength();
    int dealerStrength = dealer.calculateStrength();

    if (playerStrength > dealerStrength)
    {
        Console.WriteLine("あなたの勝ちです。");
    }
    else if (playerStrength < dealerStrength)
    {
        Console.WriteLine("あなたの負けです。");
    }
    else
    {
        Console.WriteLine("引き分けです。");
    }
}

