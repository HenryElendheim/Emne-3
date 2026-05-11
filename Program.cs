using test;
using Undervisning_Emne_3;

RunAll();
void RunAll()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("1-RPS | 2-If/Else | 3-RandomHobby | 4-TekstTukling | 5-Krokodillespillet");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                var rockPaperScissors = new RPS();
                rockPaperScissors.Run();
                break;
            case "2":
                var datatyper = new Datatyper();
                datatyper.Run();
                datatyper.NoReturn();
                Console.WriteLine("(If/else - Oppgave 3) The result is:", datatyper.Conditions3(27, 3));
                break;
            case "3":
                var RH = new RandomHobby();
                RH.Test();
                break;
            case "4":
                var TT = new TekstTukling();
                break;
            case "5":
                var KS = new Krokodillespillet();
                KS.Run();
                break;
            default:
                RunAll();
                break;
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}