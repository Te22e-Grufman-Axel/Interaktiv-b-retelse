int dörr = 0;



while (true)
{





    String choice = "";

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("                 .");
    Console.WriteLine("                .m");
    Console.WriteLine("               ,mm");
    Console.WriteLine("               MM:");
    Console.WriteLine("          .    Ymm,");
    Console.WriteLine("          M    'MMM,");
    Console.WriteLine("          M.    MMM     ,");
    Console.WriteLine("          MM,  ,MMM    .M "); //AscII art
    Console.WriteLine("          'MM, MMM'  ,MM'");
    Console.WriteLine("          ,MMM.MMMMM.MMM,");
    Console.WriteLine("          MMMMMMMMMMMMMMM");
    Console.WriteLine("          MMMMMMMMMMMMMMM");
    Console.WriteLine("           '''''''''''''");

    Console.WriteLine("");
    Console.WriteLine(""); // Tom plats mellan bilden och resten av texten
    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Du vaknar upp av att brandlarmet går av");
    Console.WriteLine("Du hoppar ur sängen och sprintar ut ur ditt rum");   //Inleding
    Console.WriteLine("Där kan du välja att gå till höger eller vänster");
    Console.WriteLine("Till höger springer du längre in i huset för att rädda dom du älskar medans till vänster flyr du själv ut ur huset");
    Console.WriteLine("Eller så kan du gå framåt in bakom en mystisk dörr");
    Console.WriteLine("Vart går du, Höger(h) eller Vänster(v) eller rakt fram(f)?");
    choice = Console.ReadLine(); //Gör choice till vad du skriver
    choice = choice.ToLower(); //Gör choice till lovercase

    if (choice == "h") // första valet
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Du kommer längre in i huset");
        Console.WriteLine("Framför dig har du 2 dörrar");
        Console.WriteLine("Men elden är nära så du kan bara välja en"); //Vad som händer effter första valet
        Console.WriteLine("Bakom dörren till höger finns din familj");
        Console.WriteLine("Och bakom dörren till vänster finns din dator med alla dina minnen och spel(Du har glömt backa upp dom på cloud)");
        Console.WriteLine("Villken dörr öppnar du, Dörren till höger(h) eller vänster(v)?");
        choice = Console.ReadLine();//se komentar på rad 8 och 9
        choice = choice.ToLower();

        if (choice == "h")//fler val
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du springer in i dörren till höger");
            Console.WriteLine("Där inne ser du din son,din dotter och din fru.");//mer val text
            Console.WriteLine("Du bär ut din son och din dotter medans din fru går ut själv");
            Console.WriteLine("Du lyckas rädda dom och ses som en hjälte i din familjs ögon");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
        }
        else if (choice == "v")//fler val
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du väljer att låta din familj brinna inne och dö en plågsam död");
            Console.WriteLine("Men du hinner ta din dator och springa ut ur huset med den");
            Console.WriteLine("Medans du springer ut hör du din fru och barn ropa dit namn och be om att bli räddade");
            Console.WriteLine("Men du väljer att ignorea dom och fortsätter springa");
            Console.WriteLine("När du kommer ut ur huset står din frus föräldrar där");
            Console.WriteLine("Du glömde att dom bodde på andra sidan gatan"); //mer val text
            Console.WriteLine("När dom ser dig springa ut ur huset med din dator och inte din familj blir dom så arga att dom slår sönder din dator");
            Console.WriteLine("Du försöker kämpa emot men det leder till att dom slår ihjäl dig också");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
        }
        else // vad som händer om du skriver fel
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du valde inget rätt val så du och din familj brann upp");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
        }
    }
    else if (choice == "v")//fler val
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Du väljer att springa ut ur huset");
        Console.WriteLine("Väl ute ser du att din frus föräldrar står där");
        Console.WriteLine("Dom ber dig springa in och rädda din fru och dina barn");//mer val text
        Console.WriteLine("Vad väljer du? Att stanna ute(u) eller att springa in igen(i)?");
        choice = Console.ReadLine();
        choice = choice.ToLower();//se komentar på rad 8 och 9

        if (choice == "u")//fler val
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du väljer att stanna ute och ser hur din familj brinner upp");//mer val text
            Console.WriteLine("Din frus föräldrar anklagar dig och ett par dar effter branden tar du självmord");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
        }
        else if (choice == "i")//fler val
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du springer in igen");
            Console.WriteLine("När du kommer till rummet dom är i är det för sent");
            Console.WriteLine("Dom är redan döda av röken i rummet"); //mer val text
            Console.WriteLine("Du försöker ta dig ut men det är för sent för dig också");
            Console.WriteLine("Du faller ihop av röken och dör");
            Console.WriteLine("");
            Console.WriteLine("Klicka på en knapp för att köra igen");
        }
        else// vad som händer om du skriver fel
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du valde inget rätt val så din familj brann upp");
            Console.WriteLine("Och din frus föräldrar dödar dig");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
        }
    }
    else if (choice == "f")
    {
        if (dörr == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du slår upp dörren och springer in");
            Console.WriteLine("Du ser att det är en trappa och kommer på att det bara är trappan ner till källaren");
            Console.WriteLine("Men det är för sent och du rammlar ner och dör");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
            dörr++;
        }
        else if (dörr == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Varför går du in här igen????");
            Console.WriteLine("Börja om och gå inte in här");
            Console.WriteLine("Du dör ju bara");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
            dörr++;
        }
        else if (dörr == 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Jag sa ju åt dig att sluta gå in här");
            Console.WriteLine("Jag varnar dig");
            Console.WriteLine("Om du går in här kommer du inte gilla det");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
            dörr++;
        }
        else if (dörr == 3)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("VARFÖR GÅR DU IN HÄR!!!!!");
            Console.WriteLine("JAG SA ATT DU INTE SKULLE GILLA DET");
            Console.WriteLine("Sista chansen");
            Console.WriteLine("Om du går in här kommer du inte GILLA DET!!!!!!!");
            Console.WriteLine("");
            Console.WriteLine("Klick på en knapp för att köra igen");
            dörr++;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Jag ger upp");
            Console.WriteLine("Varför går du in???");
            Console.WriteLine("SNälla prata bara med mig");
            Console.WriteLine("varför pågar du mig???");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Du kommer längre in i rummet");
            Console.WriteLine("DU ser att narator har tagit självmord");
            Console.WriteLine("DU set hans kropp och försöker fly");
            Console.WriteLine("Men det är för sent och du och din familj brinner upp");
            Console.WriteLine("");
            Console.WriteLine("Klicka på en knapp för att köra igen");
            dörr++;
        }
    }
    else// vad som händer om du skriver fel
    {
        Console.WriteLine("Du valde inget rätt val så du och din familj brann upp");
        Console.WriteLine("");
        Console.WriteLine("Klick på en knapp för att köra igen");
    }
Console.ReadKey();
Console.Clear();
if(dörr > 4)
{
Console.WriteLine("Du gick in i dörren du inte skulle gå igenom " + dörr + " Gånger" );
Console.WriteLine("VARFÖR????");
Console.WriteLine("");
Console.WriteLine("Tryck på en knapp för att köra igen");
}

 

}