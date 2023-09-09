using System.Linq.Expressions;

static void Soma()
{
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = v1 + v2;

    Console.Write($"O resultado da soma é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Subtrai()
{
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = v1 - v2;

    Console.Write($"O resultado da subtração é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = v1 / v2;

    Console.Write($"O resultado da divisão é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Multiplica()
{
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    float resultado = v1 * v2;

    Console.Write($"O resultado da multiplicação é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");

    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");

    Console.WriteLine(" ");
    
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;

        case 2: Subtrai(); break;

        case 3: Multiplica(); break;

        case 4: Divisao(); break;

        case 5: System.Environment.Exit(0); break;

        default: Menu(); break;
    }
}

Menu();