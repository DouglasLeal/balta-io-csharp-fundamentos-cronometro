Menu();

static void Menu()
{
	Console.Clear();
	Console.WriteLine("Cronômetro");
	Console.WriteLine("---------------");
	Console.WriteLine();
	Console.WriteLine("Digite o tempo desejado para a contagem. (Digite 0 para sair.)");

    Console.WriteLine();
    Console.WriteLine("-------------------");
    Console.WriteLine("|Exemplos:        |");
    Console.WriteLine("|10s = 10 segundos|");
    Console.WriteLine("|10m = 10 minutos |");
    Console.WriteLine("-------------------");


    Console.WriteLine();
	Console.Write("Quanto tempo deseja? ");


}

static void Start(int time)
{
	while (time >= 0)
	{
		Console.Clear();
		Console.WriteLine(time);
		Thread.Sleep(1000);
		time--;
	}

	Console.Clear();
	Console.WriteLine("Contagem finalizada... retornando para o menu...");
    Thread.Sleep(2000);

	Menu();
}