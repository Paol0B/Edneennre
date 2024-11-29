Console.WriteLine("Lento o veloce? (1, 2)");
int scelta = int.Parse(Console.ReadLine());
int slp = 0;
if (scelta == 1)
{
    slp = 500;
}
else if (scelta == 2)
{
    slp = 0;
}
else
{
    Console.WriteLine("Scelta non valida");
    return;
}



while (true)
{
    switch (rnd())
    {
        case 1:
            Console.Write("eden");
            Thread.Sleep(slp);
            break;
        case 2:
            Console.Write("red");
            Thread.Sleep(slp);
            break;
        case 3:
            Console.Write("edenred");
            Thread.Sleep(slp);
            break;
        case 4:
            Console.Write("dender");
            Thread.Sleep(slp);
            break;
        case 5:
            Console.Write("rendd");
            Thread.Sleep(slp);
            break;
        default:
            break;
    }
}

int rnd()
{
    Random rnd = new Random();
    int num = rnd.Next(1, 5);
    return num;
}