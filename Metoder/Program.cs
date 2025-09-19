
// windows();



using System.Reflection.Metadata.Ecma335;

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


// manyStars(100);


static void manyStars(int amount)
{
    for (int i = 0; i < amount; i++)
    {
        Console.SetCursorPosition(Random.Shared.Next(1, 20), Random.Shared.Next(1, 20));
        Console.Write("*");
    }

}
// string a = YesOrNo();




static string YesOrNo()
{
    bool hm = true;
    while (hm == true)
    {
        string yesNo = Console.ReadLine();
        if (yesNo == "no" || yesNo == "yes")
        {
            hm = false;
            Console.WriteLine("BRA JOBBAT!!!");
            return yesNo;
        }
    }
    return "";
}

float n = 0;
string number = Console.ReadLine();
float.TryParse(number, out n);
float c = GetCelsius(n);

Console.WriteLine(c);

static float GetCelsius(float farenheit)
{
    float celsius = (farenheit - 32f) * (5f / 9f);
    return celsius;
}



Console.ReadLine();