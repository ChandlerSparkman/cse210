public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _remainingQuestions;

    Random random = new Random();

    public ReflectionActivity()
    {
        string name = "Reflection";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int duration = 50;

        IntializeAttributes(name, description, duration);
    }

    public void Run()
    {
        DisplayStartMessage();

        string prompt = GetRandomPrompt();
        _remainingQuestions = new List<string>(_questions);

        
        for (int i = 50; i >= 0; i -= 10)
        {
            Console.Clear();
            DisplayPrompt(prompt);
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            ShowSpinner(10);
        }
        Console.WriteLine("");
        DisplayEndMessage();
    }
    
    public string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        int questionIndex = random.Next(_remainingQuestions.Count);
        string chosenQuestion = _remainingQuestions[questionIndex];
        _remainingQuestions.RemoveAt(questionIndex);
        
        return chosenQuestion;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestion(string question)
    {
        Console.Write($"Ask yourself: {question} ");
    }
}