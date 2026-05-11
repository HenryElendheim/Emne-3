using Undervisning_Emne_3;

RunAll();
void RunAll()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("1-RPS | 2-If/Else | 3-RandomHobby");
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
            default:
                RunAll();
                break;
        }
    }
}