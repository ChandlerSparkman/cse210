using System.Data;

public class FullJournal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    Random random = new Random();

    public List<string> _prompts = new List<string>
    {
        "What is something good that happened to you today?",
        "What is something bad that happened to you today?",
        "What is the weirdest thought you had today?",
        "What food are you craving right now?",
        "Is there anything you could've done better today?",
        "Is there anything you did today that you are particularly proud of?"
    };

    public void addEntry()
    {
        JournalEntry entry = new JournalEntry();
        entry._date = entry.saveDate();

        Console.Write("\nWould you like a prompt? (y/n): ");
        string command = Console.ReadLine();

        if (command == "y")
        {
            int randomChoice = random.Next(_prompts.Count);
            string prompt = _prompts[randomChoice];
            Console.WriteLine($"\nPrompt: {prompt}");
            entry._prompt = prompt;
        }
        else
        {
            entry._prompt = "None";
        }

        Console.WriteLine("\nEnter entry: ");
        entry._content = Console.ReadLine();

        Console.WriteLine("\nEntry saved as:");
        Console.WriteLine($"\n{entry._date}");
        if (entry._prompt != "None")
        {
            Console.WriteLine($"Prompt: {entry._prompt}\n");
        }
        Console.WriteLine($"{entry._content}\n");

        _entries.Add(entry);
    }

    public void printJournal()
    {
        foreach (JournalEntry entry in _entries)
        {
            Console.WriteLine($"\n{entry._date}");
            if (entry._prompt != "None")
            {
                Console.WriteLine($"Prompt: {entry._prompt}\n");
            }
            Console.WriteLine($"{entry._content}\n");
        }
    }

    public void savetoFile()
    {
        Console.Write("\nSave as? (Be sure to not include the extension.): ");
        string filename = Console.ReadLine();
        filename = filename + ".txt";

        using (StreamWriter savedJournal = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                string fileLine = entry._date + "|" + entry._prompt + "|" + entry._content;
                savedJournal.WriteLine(fileLine);
            }
            Console.WriteLine($"\nFile saved as {filename}!\n");
        }
    }
    public void loadfromFile()
    {
        _entries.Clear();
        Console.Write("\nWhat file would you like to load? (Be sure to not include the extension.): ");
        string filename = Console.ReadLine();
        filename = filename + ".txt";

        string[] fileLines = System.IO.File.ReadAllLines(filename);

        foreach (string fileLine in fileLines)
        {
            JournalEntry entry = new JournalEntry();

            string[] parts = fileLine.Split("|");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._content = parts[2];

            _entries.Add(entry);
        }

        Console.WriteLine($"\nSuccessfully loaded {_entries.Count} entries from {filename}!\n");
    }
}