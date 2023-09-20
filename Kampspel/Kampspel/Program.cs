int spelareHP = 100;
int aihp = 100;
int maxskada = 35;
int maxrundor = 5;

String inst = "";
String instval = "";
String nameval = "";
String Spelarename = ("Hero");
String aiName = ("Villan");
Random Skada = new Random();
while (true)
{
    int runda = 0;
    int nuvaranespelarhp = spelareHP;
    int nuvaraneaihp = aihp;
    Console.WriteLine("Välkomen till Axels slagsmål spel");
    Console.WriteLine("För att gå in i instälnignar tryck på i");
    Console.WriteLine("För att starta spelet tryck på en annan knapp");
    inst = Console.ReadLine();
    inst = inst.ToLower();
    Console.Clear();
    if (inst == "i")
    {
        Console.WriteLine("Välkommen till instälnignar");
        Console.WriteLine("Här kan du välja olika instänlnignar");
        Console.WriteLine("Namn på spelaren(N)");
        Console.WriteLine("Namn på fiende(F)");
        Console.WriteLine("Max attack(A)");
        Console.WriteLine("Max rundor(R)");
        Console.WriteLine("Spelaren hp(S)");
        Console.WriteLine("Motståndarens hp(M)");
        Console.WriteLine("");
        Console.WriteLine("För att välja vad du vill ändra så skriv bokstaven brevid instälginar");
        instval = Console.ReadLine();
        instval = instval.ToLower();
        if (instval == "n")
        {
            Console.WriteLine("Vad vill du ändra nammnet till?");
            Spelarename = Console.ReadLine();

        }
        else if (instval == "f")
        {
            Console.WriteLine("Välj mellan 3 namn eller skapa dit egna");
            Console.WriteLine("Namn 1: Enemy");
            Console.WriteLine("Name 2: Villan");
            Console.WriteLine("Namn 3; opponent");
            Console.WriteLine("Namn 4: Eget namn");
            nameval = Console.ReadLine();
            nameval = nameval.ToLower();
            {
                if (nameval == "1")
                {
                    aiName = "Enemy";
                }
                if (nameval == "2")
                {
                    aiName = "Vilan";
                }
                if (nameval == "3")
                {
                    aiName = "Opponent";
                }
                if (nameval == "4")
                {
                    Console.WriteLine("Vad ska han heta?");
                    aiName = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Vet inte vad du sa, skriv igen");
                }
            }
        }
        else if (instval == "a")
        {
            Console.WriteLine("Vad ska max attack vara?");
            Console.WriteLine("Just nu är det " + maxskada);

            string tmpMaxskada = Console.ReadLine();
            bool success = int.TryParse(tmpMaxskada, out maxskada);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }

        }
        else if (instval == "r")
        {
            Console.WriteLine("Vad ska max rundor vara?");
            Console.WriteLine("Just nu är det " + maxrundor);

            string tmpMaxrundor = Console.ReadLine();
            bool success = int.TryParse(tmpMaxrundor, out maxrundor);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else if (instval == "s")
        {
            Console.WriteLine("Vad ska spelaren ha för hp?");
            Console.WriteLine("Just nu är det " + spelareHP);

            string tmpspelarHp = Console.ReadLine();
            bool success = int.TryParse(tmpspelarHp, out spelareHP);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else if (instval == "m")
        {
            Console.WriteLine("Vad ska " + aiName + " ha för hp");
            Console.WriteLine("Just nu är det " + aihp);

            string tmpaihp = Console.ReadLine();
            bool success = int.TryParse(tmpaihp, out aihp);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else
        {
            Console.WriteLine("Jag vet inte vad du sa, skriv igen");
        }
    }
    else
    {




        while (nuvaranespelarhp > 0 && nuvaraneaihp > 0 && runda < maxrundor)
        {
            Console.WriteLine("          Ny Runda");
            Console.WriteLine("");
            Console.WriteLine(Spelarename + " börjar rundan med " + nuvaranespelarhp + " hp");
            Console.WriteLine(aiName + " börjar rundan med " + nuvaraneaihp + " hp");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            int spelaredamage = Skada.Next(maxskada);
            nuvaraneaihp -= spelaredamage;
            Console.WriteLine(Spelarename + " attakerar " + aiName + " och gör " + spelaredamage + " i skada");
            Console.WriteLine(aiName + " har nu " + nuvaraneaihp + " i hp");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int aidamage = Skada.Next(maxskada);
            nuvaranespelarhp -= aidamage;
            Console.WriteLine(aiName + " attakerar " + Spelarename + " och gör " + aidamage + " i skada");
            Console.WriteLine(Spelarename + " har nu " + nuvaranespelarhp + " i hp");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Tryck på en valfri knapp för att köra igen");
            Console.ReadKey();
            Console.Clear();
            runda++;
        }

        if (nuvaranespelarhp <= 0 && nuvaraneaihp <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Båda dog och det blev ovagjort");
        }
        else if (nuvaranespelarhp <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine(aiName + " Vann och dödade " + Spelarename);
        }
        else if (nuvaraneaihp <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine(Spelarename + " vann och dödade " + aiName);
        }
        else
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Slut på rundor");
        }

    }
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Tryck på en valfri knapp för att köra igen");
    Console.ReadKey();
    Console.Clear();
}


