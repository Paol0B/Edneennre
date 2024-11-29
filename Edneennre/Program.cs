///     V       V   AAAAA   RRRRR   IIIIIII   AAAAA   BBBBB  IIIIIII  L      IIIIIII
///      V     V   A     A  R    R     I     A     A  B    B    I     L         I   
///       V   V    AAAAAAA  RRRRR      I     AAAAAAA  BBBBB     I     L         I   
///        V V     A     A  R   R      I     A     A  B    B    I     L         I   
///         V      A     A  R    R  IIIIIII  A     A  BBBBB  IIIIIII  LLLLLL IIIIIII
///     
#region variabili

#endregion





///     M       M   AAAAA   IIIIIII N     N
///     MM     MM  A     A     I    NN    N
///     M M   M M  AAAAAAA     I    N N   N
///     M  M  M M  A     A     I    N  N  N
///     M   M   M  A     A  IIIIIII N   N N


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




///   CCCCC     L         AAAAA    SSSSS   SSSSS   IIIIIII
///  C          L        A     A  S       S           I  
///  C          L        AAAAAAA   SSSSS   SSSSS      I  
///  C          L        A     A        S       S     I  
///  CCCCC      LLLLLL   A     A   SSSSS   SSSSS   IIIIIII

#region classi

#endregion







///     M       M  EEEEEEE  TTTTTTT  OOOOO   DDDDD    IIIIIII
///     MM     MM  E           T    O     O  D    D      I  
///     M M   M M  EEEE        T    O     O  D     D     I  
///     M  M  M M  E           T    O     O  D    D      I  
///     M   M   M  EEEEEEE     T     OOOOO   DDDDD    IIIIIII

#region metodi
int rnd()
{
    Random rnd = new Random();
    int num = rnd.Next(1, 5);
    return num;
}
#endregion