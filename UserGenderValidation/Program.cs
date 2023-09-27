// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal vvalida tema sugu (m või n)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt
//"Welcome, Mr. [Kasutaja perekonnanimi]/ "Welcome, Ms. [Kasutaja perekonnanimi]


Console.WriteLine("Please, select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}



Console.WriteLine($"Welcome, {userGender}");
