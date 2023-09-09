static void Menu(){
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("E = Exit");

    string opcao = Console.ReadLine();

    switch(opcao){
        case "s": Segundo(); break;
        case "m": Minuto(); break;
        case "e": Environment.Exit(0); break;
    }
    
}

static void Segundo()
{
    Console.WriteLine("Quanto tempo deseja cronometrar?");
    int time = int.Parse(Console.ReadLine());
    int currentTime = 0;

    while (currentTime != time){

        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);

        Thread.Sleep(1000);
        
    }

    Console.Clear();
    Console.WriteLine("Cronômetro encerrado.");
    Thread.Sleep(2500);
}

static void Minuto()
{
    Console.WriteLine("Quanto tempo deseja cronometrar?");
    int time = int.Parse(Console.ReadLine());
    int currentTime = 0;
    

    while (currentTime != (time * 60)){

        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);

        Thread.Sleep(time * 1000);
        
    }

    Console.Clear();
    Console.WriteLine("Cronômetro encerrado.");
    Thread.Sleep(2500);
}

Menu();