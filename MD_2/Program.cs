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


//---------------------------------------------

Console.WriteLine("Min/Max uzdevums ");

Console.WriteLine("Ievadi pirmo skaitli");
int skaitlis1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli");
int skaitlis2 = int.Parse(Console.ReadLine());

int maxSkaitlis = Math.Max(skaitlis1, skaitlis2);
Console.WriteLine("Max skaitlis: " + maxSkaitlis);

int minSkaitlis = Math.Min(skaitlis1, skaitlis2);
Console.WriteLine($"Min skaitlis: {minSkaitlis}");

