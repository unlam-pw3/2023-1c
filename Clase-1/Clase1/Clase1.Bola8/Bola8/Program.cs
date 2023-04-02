using Bola8;

internal class Program
{
    private static void Main(string[] args)
    {
        Bola bola = new Bola();
        bola.WelcomeMsg();
        string question = bola.AskMe();

        while(!question.StartsWith("x"))
        {
            string response = bola.GetRandomResponse(question);
            Console.WriteLine(response);
            question = bola.AskMe();
        }
        bola.CloseGame(question);

    }
}