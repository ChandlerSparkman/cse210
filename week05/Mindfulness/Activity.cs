public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void IntializeAttributes(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.Write($"Starting {_name} activity...   ");
        ShowSpinner(2);
        Console.Clear();
    }

    public void DisplayEndMessage()
    {
        Console.Write("Activity end. Enter anything to return to menu:");
        Console.ReadLine();
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < (1000 * seconds); i += 500)
        {
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b \b");
        }
    }

    public void ShowCountdown(int length)
    {
        for (int i = length; i >= 0; i--)
        {
            string iString = i.ToString();

            if (i < 10)
            {
                iString = " " + iString;
            }

            Console.Write(iString);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }
}