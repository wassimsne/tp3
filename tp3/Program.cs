// See https://aka.ms/new-console-template for more information
using tp3.StringExtension;

Console.WriteLine("Hello, World!");
"Debut".dump();
//CalculSync();
//Task.Run( () =>  Calculaasync());

Task<int> x= Calculerasync();
x.ContinueWith(t => Afficher(t.Result));
CalculSync();



//await Calculaasync();   
"Fin".dump();
Console.ReadLine();



void CalculSync()
{
    "DebutCalculsync".dump(ConsoleColor.Blue);
    for (int i=0; i < 10000; i++)
    {
        for (int j = 0; j < 100000; j++) ;
        
    }
    "FinCalculSimple".dump(ConsoleColor.Green);
}
int CalculsSync()
{
    "DebutCalculasync".dump(ConsoleColor.Blue);
    for (int i = 0; i < 10000; i++)
    {
        for (int j = 0; j < 100000; j++) ;

    }
    "FinCalculSimple".dump(ConsoleColor.Green);
    return (10);
}

Task Calculaasync()//Sans ype de retour
{
    "DebutCalculasync".dump(ConsoleColor.Red);
    for (int i = 0; i < 10000; i++)
    {
        for (int j = 0; j < 10000; j++) ;

    }
    "FinCalculSimple".dump(ConsoleColor.Yellow);

    return Task.CompletedTask;
}
Task<int> Calculerasync()//Avec type de retour
{

    "DebutCalculasync".dump(ConsoleColor.Red);
    for (int i = 0; i < 10000; i++)
    {
        for (int j = 0; j < 10000; j++) ;

    }
    "FinCalculSimple".dump(ConsoleColor.Yellow);

    return Task.FromResult(10);
}  
void Afficher(int resulatat)
{
    "Le resulaat est ".dump(ConsoleColor.Red);
    int x=150 * resulatat;
    Console.WriteLine(x);
}