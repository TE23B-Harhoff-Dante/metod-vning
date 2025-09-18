manyStars(100);
windows();
YesOrNo();
Console.ReadLine();

static void windows()
{
    Console.WriteLine("""
             _.-;;-._
      '-..-'|   ||   |
      '-..-'|_.-;;-._|
      '-..-'|   ||   |
jgs   '-..-'|_.-''-._|
""");

    Console.WriteLine("       _.-;;-._");
    Console.WriteLine("'-..-'|   ||   |");
    Console.WriteLine("'-..-'|_.-;;-._|");
    Console.WriteLine("'-..-'|   ||   |");
    Console.WriteLine("'-..-'|_.-''-._|");
}

static void manyStars(int amount)
{
    for (int i = 0; i < amount; i++)
    {
        Console.SetCursorPosition(Random.Shared.Next(1, 20), Random.Shared.Next(1, 20));
        Console.Write("*");
    }

}

static void YesOrNo()
{
    bool hm = true;
    while ( hm == true)
    {
        string yesNo = Console.ReadLine();
        if (yesNo == "no" || yesNo == "yes")
        {
            hm = false;
        }
    }
    
}