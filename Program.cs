Console.WriteLine("skriv in din fotbolls idol:");

string name = Console.ReadLine();

Console.WriteLine("vad bra att du valde " + name +" ");
Console.WriteLine("vem är den bästa fotbollspelaren?");
String spelare = Console.ReadLine();
Console.ReadLine();
Console.WriteLine("är du säker att "+ spelare + " är den bästa?");

string val = Console.ReadLine();

if(val == "nej") {
    System.Console.WriteLine("exact för ronaldo är bäst");
}else {
    Console.WriteLine("fel Ronaldo är bäst");
}

Console.ReadLine();
