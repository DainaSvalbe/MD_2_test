// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kā tevi sauc?");
string name = Console.ReadLine();
Console.WriteLine("Sveiks, " + name);

Console.WriteLine("Kāds ir tavs vecums?");
string ageStr = Console.ReadLine();
int age1 = int.Parse(ageStr);

int age2 = age1 + 1;

Console.WriteLine("Nākamgad tev paliks " + age2 + ". Tu esi pingadīgs?");
int limit = 18;

bool pilngadigs = age1 >= limit;

Console.WriteLine(pilngadigs);



