public class Chapter
{
    public string Title;
    public List<Page> Pages;
    public Chapter(string title)
    {
        Title = title;
        Pages = new List<Page>();
    }

    public Chapter(string title, List<Page> pages)
    {
        Title = title;
        Pages = pages;
    }

    public void Read()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Title);
        Console.ResetColor();
        Console.WriteLine("\nChapter contents:");
        foreach (Page page in Pages)
        {
            page.Read();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        Console.Clear();
        Console.WriteLine("You have finished reading the chapter. Do you want to start the quiz? (yes/no)");

string response = Console.ReadLine();

if (response.ToLower() == "yes")
{
    // Start the quiz
    Quiz.StartQuiz();
}
else
{
    // Provide any other desired actions or exit the program
    Console.WriteLine("Thank you for reading. Have a nice day!");
    Thread.Sleep(1000);
}
    }
}