int spelareHP = 100;
int aihp = 100;
int maxskada = 3;
int maxrundor = 5;
int runda = 0;
String Spelarename = ("Hero");
String aiName = ("Villan");
Random Skada = new Random();

Console.WriteLine("Välkomen till Axels slagsmål spel");
Console.WriteLine("För att gå in i instälnignar tryck på i");
Console.WriteLine("För att starta spelet tryck på en annan knapp");
if(Console.ReadKey("i"))
{
    
}





    while (spelareHP > 0 && aihp > 0 && runda < maxrundor)
    {
        Console.WriteLine("          Ny Runda");
        Console.WriteLine("");
        Console.WriteLine(Spelarename + " börjar rundan med " + spelareHP + " hp");
        Console.WriteLine(aiName + " börjar rundan med " + aihp + " hp");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        int spelaredamage = Skada.Next(maxskada);
        aihp -= spelaredamage;
        Console.WriteLine(Spelarename + " attakerar " + aiName + " och gör " + spelaredamage + " i skada");
        Console.WriteLine(aiName + " har nu " + aihp + " i hp");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        int aidamage = Skada.Next(maxskada);
        spelareHP -= aidamage;
        Console.WriteLine(aiName + " attakerar " + Spelarename + " och gör " + aidamage + " i skada");
        Console.WriteLine(Spelarename + " har nu " + spelareHP + " i hp");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine();
        Console.WriteLine("Tryck på en valfri knapp för att köra igen");
        Console.ReadKey();
        Console.Clear();
        runda++;
    }

if (spelareHP <= 0 && aihp <= 0)
{
    Console.WriteLine("Game over");
    Console.WriteLine("Båda dog och det blev ovagjort");
}
else if (spelareHP <= 0)
{
    Console.WriteLine("Game over");
    Console.WriteLine(aiName + " Vann och dödade " + Spelarename);
}
else if (aihp <= 0)
{
    Console.WriteLine("Game over");
    Console.WriteLine(Spelarename + " vann och dödade " + aiName);
}
else
{
    Console.WriteLine("Game over");
    Console.WriteLine("Slut på rundor");
}


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Tryck på en valfri knapp för att köra igen");
Console.ReadKey();
Console.Clear();



