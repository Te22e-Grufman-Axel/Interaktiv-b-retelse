String choice = "";

Console.WriteLine("Du vaknar upp av att brandlarmet går av");
Console.WriteLine("Du hoppar ur sängen och sprintar ut ur ditt rum");
Console.WriteLine("Där kan du välja att gå till höger eller vänster");
Console.WriteLine("Till höger springer du längre in i huset för att rädda dom du älskar medans till vänster flyr du själv ut ur huset");
Console.WriteLine("Vart går du, Höger(h) eller Vänster(v)?");
choice = Console.ReadLine();
choice = choice.ToLower();

if(choice == "h")
{
Console.WriteLine("Du kommer längre in i huset");
Console.WriteLine("Framför dig har du 2 dörrar");
Console.WriteLine("Men elden är nära så du kan bara rädda en");
Console.WriteLine("Bakom dörren till höger finns din familj");
Console.WriteLine("Och bakom dörren finns din dator med alla dina minnen och spel(Du har glömt backa upp dom på cloud)");
Console.WriteLine("Villken dörr öppnar du, Dörren till höger(h) eller vänster(v)?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "h")
{
Console.WriteLine("Du springer in i dörren till höger");
Console.WriteLine("Där inne ser du din son,din dotter och din fru.");
Console.WriteLine("Du bär ut din son och din dotter medans fin fru går ut själv");
Console.WriteLine("Du lyckas rädda dom och ses som en hjälte i din familjs ögon");
}
else if (choice == "v")
{
Console.WriteLine("Du väljer att låta din familj brinna och dö en plågsam död");
Console.WriteLine("Men du hinner ta din dator och springa ut ur huset med den");
Console.WriteLine("Medans du springer ut hör du din fru och barn ropa dit namn och be om att bli räddade");
Console.WriteLine("Men du väljer att ignorea dom och fortsätter springa");
Console.WriteLine("När du kommer ut ur huset står din frus föräldrar du");
Console.WriteLine("Du glömde att dom bodde på andra sidan gatan");
Console.WriteLine("När dom ser dig spring ut ur huset med din dator och inte din familj blir dom så arga att dom slår sönder din dator");
Console.WriteLine("Du försöker kämpa imot men det leder till att dom slår ihjäl dig också");
}
else
{
Console.WriteLine("Du valde inget rätt val så du och din familj bran upp");
}
}
else if(choice == "v")
{
Console.WriteLine("Du väljer att springa ut ur huset");
Console.WriteLine("Väl ute ser du din frus föräldrar står där");
Console.WriteLine("Dom ber dig springa in och rädda din fur och dina bara");
Console.WriteLine("Vad väljer du? Att stana ute(u) eller att sprina in igen(i)?");
choice = Console.ReadLine();
choice = choice.ToLower();

if(choice == "u")
{
Console.WriteLine("Du väljer att stanna ute och ser hur din familj brinner upp");
Console.WriteLine("Din frus föräldrar anklagar dig och ett par dar effter branden tar du självmord");
}
else if( choice == "i")
{
Console.WriteLine("Du springer in igen");
Console.WriteLine("När du kommer till rummet dom är i är det för sent");
Console.WriteLine("Dom är redan döda av röken i rummet");
Console.WriteLine("Du försöker ta dig ut men det är för sent för dig också");
Console.WriteLine("Du faller ihop av röken och dör");
}
else
{
    Console.WriteLine("Du valde inget rätt val så din familj bran upp");
    Console.WriteLine("Och din frus föräldrar dödar dig");
}

}
else
{
    Console.WriteLine("Du valde inget rätt val så du och din familj bran upp");
}



Console.ReadLine();