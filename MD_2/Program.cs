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

//--------------------------------------------------

Console.WriteLine("Daliijuma atlikums uzdevums ");

Console.WriteLine("Ievadi pirmo skaitli");
int skaitlis11 = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli");
int skaitlis22 = int.Parse(Console.ReadLine());

int atlikums = skaitlis11 % skaitlis22;
Console.WriteLine($"Daliijuma atlikums: {atlikums}");

//---------------------------------------------------------

Console.WriteLine("Vai ir paara/nepaara skaitlis");

Console.WriteLine("Ievadi skaitli");
int skaitlis111 = int.Parse(Console.ReadLine());
bool paraSkaitlis = skaitlis111 % 2 == 0;

Console.WriteLine("Vai ir paara skaitlis? " + paraSkaitlis);


//------------------------------------

Console.WriteLine("Kāds ir taisnstura laukums?");

Console.WriteLine("Ievadi pirmo skaitli");
//double sk1 = double.Parse(Console.ReadLine());
string strSK1 = Console.ReadLine();
var sk1 = double.Parse(strSK1);
Console.WriteLine("Ievadi otro skaitli");
//double sk2 = double.Parse(Console.ReadLine());
string strSK2 = Console.ReadLine();
var sk2 = double.Parse(strSK2);

double laukums1 = sk1 * sk2;
double laukums = Math.Round(laukums1, 2);

Console.WriteLine($"Taisnstura laukums ir {laukums}");



//------------------------------------

Console.WriteLine("Kāds ir taislenca trijstura laukums?");

Console.WriteLine("Ievadi pirmo skaitli");
//double sk11 = double.Parse(Console.ReadLine());
string strSK11 = Console.ReadLine();
var sk11 = double.Parse(strSK11);
Console.WriteLine("Ievadi otro skaitli");
//double sk2 = double.Parse(Console.ReadLine());
string strSK22 = Console.ReadLine();
var sk22 = double.Parse(strSK22);

double laukums2 = sk11 * sk22 / 2;
double laukums22 = Math.Round(laukums2, 2);

Console.WriteLine($"Taisnstura laukums ir {laukums22}");

//------------------------------------------------------------

Console.WriteLine("Kā tevi sauc?");
string vards = Console.ReadLine();

Console.WriteLine("Kāds ir tavs vecums?");
int vecums = int.Parse(Console.ReadLine());

Console.WriteLine($"Sveiks {vards}, tavs vecums ir {vecums}.");


