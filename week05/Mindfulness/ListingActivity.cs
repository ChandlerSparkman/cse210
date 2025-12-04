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

    public ListingActivity()
    {
        string name = "Listing";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int duration = 70;

        IntializeAttributes(name, description, duration);
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Please answer the following prompt as many times as you can within 60 seconds.");
        string chosenPrompt = GetRandomPrompt();
        Console.WriteLine(chosenPrompt);
      
        Console.Write("Think of your answers... ");

        ShowCountdown(10);

        List<string> userInput = GetListFromUser();

        Console.Clear();
        Console.WriteLine($"Prompt: {chosenPrompt}\nAnswers ({userInput.Count}):");
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
        int timeLeft = 60;
        bool timeUp = false;

        Console.WriteLine("Start listing: ");

        Task.Run(() =>
        {
            while (timeLeft > 0)
            {
                Thread.Sleep(1000);
                timeLeft--;
            }

            timeUp = true;
            Console.WriteLine("\nTime's up! Enter anything to continue. ");
        });

        while (timeUp == false)
        {
            string answer = Console.ReadLine();
            
            if (timeUp == false)
            {
                userInput.Add(answer);
            }
        }
        return userInput;
    }
}