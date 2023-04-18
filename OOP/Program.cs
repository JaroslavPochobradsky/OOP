using OOP;
Console.WriteLine("chceš vypočítat: objem, povrch, telesovou uhlopricku nebo stenovou uhlopricku?");
string odpoved = Console.ReadLine();
if (odpoved == "objem")
{
    Objekt objekt = new Objekt();
    Console.WriteLine("Zadej délky stran");
    int cislo1 = int.Parse(Console.ReadLine());
    int cislo2 = int.Parse(Console.ReadLine());
    int cislo3 = int.Parse(Console.ReadLine());
    int objem = objekt.objemObjektu(cislo1, cislo2, cislo3);
    Console.WriteLine("zde je objem tělesa: " + objem);
}
else if (odpoved == "povrch")
{
    Objekt objekt = new Objekt();
    Console.WriteLine("Zadej délky stran");
    int cislo1 = int.Parse(Console.ReadLine());
    int cislo2 = int.Parse(Console.ReadLine());
    int cislo3 = int.Parse(Console.ReadLine());
    int povrch = objekt.povrchObjektu(cislo1, cislo2, cislo3);
    Console.WriteLine("zde je povrch tělesa: " + povrch);
}
else if (odpoved == "tělesová úhlopříčka")
{
    Objekt objekt = new Objekt();
    Console.WriteLine("zadej délky stran");
    int cislo1 = int.Parse(Console.ReadLine());
    int cislo2 = int.Parse(Console.ReadLine());
    int cislo3 = int.Parse(Console.ReadLine());
    int uhloprickaT = objekt.telesovaUhlopricka(cislo1, cislo2, cislo3);
    Console.WriteLine("zde je tělesová úhlopříčka: " + uhloprickaT);
}
else
{
    Objekt objekt = new Objekt();
    Console.WriteLine("zadej délky stran");
    int cislo1 = int.Parse(Console.ReadLine());
    int cislo2 = int.Parse(Console.ReadLine());
    int uhloprickaS = objekt.stenovaUhlopricka(cislo1, cislo2);
    Console.WriteLine("zde je stěnová úhlopříčka: " + uhloprickaS);
}