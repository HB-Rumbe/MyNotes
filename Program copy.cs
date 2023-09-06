public class Quiz
{
    public static void StartQuiz()
    {
        Console.WriteLine("Hvad er meningen med livet?");
        Console.WriteLine("A. lykke");
        Console.WriteLine("B. at få børn");
        Console.WriteLine("C. 42");
        Console.WriteLine("D. penge");
        Console.Write("Your answer (A/B/C/D): ");
        
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToUpper() == "C")
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }
    }
}