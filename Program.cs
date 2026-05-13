using test;
using Undervisning_Emne_3;

RunAll();
void RunAll()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("1-RPS | 2-If/Else | 3-RandomHobby | 4-TekstTukling | 5-Krokodillespillet" +
            "\n\n6-HvaGjørDenneKoden | 7-GjettTallet " +
            "\n\n8-KlasserOgProperties_Constructor_ObjekterIList" +
            "\n\n9-MethodOverload_DefaultValues | 10-? | 11-?" +
            "\n\n");
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
                Console.WriteLine("Here you can write a name and a level! (Type 'exit' to leave)");
                var inputName = Console.ReadLine();
                var inputLvl = Convert.ToInt32(Console.ReadLine());
                var KOP = new KlasserOgProperties(inputName, inputLvl);
                KOP.Run();
                break;
            case "9":
                var MODV = new MethodOverload_DefaultValues();
                MODV.PrintWelcomeMessage();
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