using System;
using System.Text;



///     V       V   AAAAA   RRRRR   IIIIIII   AAAAA   BBBBB  IIIIIII  L      IIIIIII
///      V     V   A     A  R    R     I     A     A  B    B    I     L         I   
///       V   V    AAAAAAA  RRRRR      I     AAAAAAA  BBBBB     I     L         I   
///        V V     A     A  R   R      I     A     A  B    B    I     L         I   
///         V      A     A  R    R  IIIIIII  A     A  BBBBB  IIIIIII  LLLLLL IIIIIII
///     
#region variabili
// Variabile in cui sarà registrato tutto
string entireText = string.Empty;

// bool per timer
bool isTimerElapsed = false;


#endregion





///     M       M   AAAAA   IIIIIII N     N
///     MM     MM  A     A     I    NN    N
///     M M   M M  AAAAAAA     I    N N   N
///     M  M  M M  A     A     I    N  N  N
///     M   M   M  A     A  IIIIIII N   N N

Console.WriteLine("Benvenuto al selezionatore automatico di Edneennre");
Thread.Sleep(5);
Console.WriteLine("Scegli la velocità del testo: \n 1= Lento\n 2= Veloce");

int scelta = int.Parse(Console.ReadLine());

int slp = 0;

if (scelta == 1)
{
    slp = 500;
}
else if (scelta == 2)
{
    // TO DO:
    // Trovare una soluzione migliore, così è troppo lento, per il veloce
    slp = 1;
}
else
{
    Console.WriteLine("Scelta non valida");
    return;
}


Console.WriteLine("Scegli per quanto tempo il testo verrà scritto: \n 1= 1 secondo\n 2= 5 secondi\n 3= 10 secondi");

int scelta2 = int.Parse(Console.ReadLine());

int timr = 0;

if (scelta2 == 1)
{
    timr = 1000;
}
else if (scelta2 == 2)
{
    timr = 5000;
}
else if (scelta2 == 3)
{
    timr = 10000;
}
else
{
    Console.WriteLine("Scelta non valida");
    return;
}

/// Costruttori
// stringbuilder
StringBuilder sb = new StringBuilder();

// timer
System.Timers.Timer timer = new System.Timers.Timer(timr);
timer.Elapsed += (sender, e) => { isTimerElapsed = true; };
timer.AutoReset = false;
timer.Enabled = true;


while (timr >0)
{
    switch (rnd())
    {
        case 1:
            Console.Write("eden");
            sb.Append("eden");
            Thread.Sleep(slp);
            break;
        case 2:
            Console.Write("red");
            sb.Append("red");
            Thread.Sleep(slp);
            break;
        case 3:
            Console.Write("edenred");
            sb.Append("edenred");
            Thread.Sleep(slp);
            break;
        case 4:
            Console.Write("dender");
            sb.Append("dender");
            Thread.Sleep(slp);
            break;
        case 5:
            Console.Write("rendd");
            sb.Append("rendd");
            Thread.Sleep(slp);
            break;
        default:
            break;
    }
    timr -= slp;
}


entireText = sb.ToString();
// Ottieni il percorso del file sul desktop
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string filePath = Path.Combine(desktopPath, "Edneennre.txt");

// Scrivi il contenuto della stringa sul file
File.WriteAllText(filePath, entireText);

//end script


///   CCCCC     L         AAAAA    SSSSS   SSSSS   IIIIIII
///  C          L        A     A  S       S           I  
///  C          L        AAAAAAA   SSSSS   SSSSS      I  
///  C          L        A     A        S       S     I  
///  CCCCC      LLLLLL   A     A   SSSSS   SSSSS   IIIIIII

#region classi
///
///  Anche se vuoto, NON ELIMINARLO
/// 
/// 
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