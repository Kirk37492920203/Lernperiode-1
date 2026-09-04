Console.WriteLine("Erste Note Informatik");
    Double note = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Zweite Note Informatik");
Double note1  = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dritte Note Informatik");
Double note2 = Convert.ToDouble(Console.ReadLine());
Double durchschnitt = (note + note1 + note2) / 3.0;
Console.WriteLine("Dein Informatik schnitt ist :" + durchschnitt);
Console.ReadKey();
Console.WriteLine("Erste Note Sport");
Double spote = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Zweite Note Sport");
Double spote1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Dritte Note Sport");
Double spote2 = Convert.ToDouble(Console.ReadLine());
Double sportdurchschnitt = (spote + spote1 + spote2) / 3.0;
Console.WriteLine("Dein Sport schnitt ist :" + sportdurchschnitt);
Console.ReadKey();
Double Gesamtschnitt = (durchschnitt + sportdurchschnitt) / 2.0;
Console.WriteLine("Dein Gesamtschnitt ist: " + Gesamtschnitt);
if (Gesamtschnitt >= 4)
{
    Console.WriteLine("Du hast bestanden!!");
}
else
{
    Console.WriteLine("Du hast es nicht geschafft ayri");
}
    Console.ReadLine();
