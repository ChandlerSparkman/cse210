public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    Random random = new Random();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Please answer the following prompt as many times as you can within 60 seconds.");
        string chosenPrompt = GetRandomPrompt();
        Console.WriteLine(chosenPrompt);
      
        Console.WriteLine("I'll give you 10 seconds to think about it.");

        Thread.Sleep(10000);

        List<string> userInput = GetListFromUser();

        Console.Clear();
        Console.WriteLine($"Prompt: {chosenPrompt}\nAnswers:");
        foreach (string answer in userInput)
        {
            Console.WriteLine(answer);
        }

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(60);

        Console.WriteLine("You have 60 seconds! Start listing!");

        while (DateTime.Now < endTime)
        {
            Console.Write("");
            string answer = Console.ReadLine();
            userInput.Add(answer);
            Thread.Sleep(50);
        }

        return userInput;
    }
}