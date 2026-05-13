using test;
using Undervisning_Emne_3;


RunAll();
void RunAll()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("1-RPS | 2-If/Else | 3-RandomHobby | 4-TekstTukling | 5-Krokodillespillet\n6-HvaGjørDenneKoden | 7-GjettTallet");
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
                RH.Run();
                break;
            case "4":
                var TT = new TekstTukling();
                TT.Run();
                break;
            case "5":
                var KS = new Krokodillespillet();
                KS.Run();
                break;
            case "6":
                var HGDK = new HvaGjørDenneKoden();
                HGDK.Run();
                break;
            case "7":
                var GT = new GjettTallet();
                GT.Run();
                break;
            case "8":
                
                break;
            case "9":

                break;
            case "10":

                break;
            default:
                RunAll();
                break;
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}