Start();

static void Start()
{
    int time = 10;

	while (time >= 0)
	{
		Console.Clear();
		Console.WriteLine(time);
		Thread.Sleep(1000);
		time--;
	}
}