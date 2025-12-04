public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        string name = "Listing";
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int duration = 40;

        IntializeAttributes(name, description, duration);
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.Write("Take a deep breath in. ");
        ShowSpinner(5);
        Console.Clear();
        
        Console.Write("Now breathe out. ");
        ShowSpinner(5);
        Console.Clear();

        for (int i = 30; i >= 0; i -= 10)
        {
            Console.Write("Breathe in. ");
            ShowSpinner(5);
            Console.Clear();

            Console.Write("Breathe out. ");
            ShowSpinner(5);
            Console.Clear();
        }

        DisplayEndMessage();
    }
}