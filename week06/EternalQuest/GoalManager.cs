public class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    public int _score = 0;
    public int _level = 1;
    public double _nextLevel = 100;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine($"Level: {_level}");
            Console.WriteLine($"Score: {_score} (Next level: {_nextLevel})");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("Select: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") return;
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.ReadLine();
        Console.Clear();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Which type: ");
        string type = Console.ReadLine();

        Console.Clear();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, pts));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, pts));
        }
        else if (type == "3")
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
        Console.Clear();
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalDetails();
        Console.Write("Which goal: ");
        int g = int.Parse(Console.ReadLine()) - 1;

        int pts = _goals[g].RecordEvent();
        _score += pts;

        Console.WriteLine("Points earned: " + pts);

        bool doneCalcEXP = false;
        bool leveledUp = false;
            while (doneCalcEXP == false)
            {
                if (_score >= _nextLevel)
                {
                    _level ++;
                    leveledUp = true;
                    _nextLevel = Math.Round(_nextLevel * 1.5);
                }
                else
                {
                    doneCalcEXP = true;
                }
            }
        
        if (leveledUp == true)
        {
            Console.WriteLine($"You leveled up!\nNow level {_level}");
        }

        Console.ReadLine();
        Console.Clear();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.Clear();
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("File name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');

            if (p[0] == "Simple")
            {
                var g = new SimpleGoal(p[1], p[2], int.Parse(p[3]));
                g._isComplete = bool.Parse(p[4]);
                _goals.Add(g);
            }
            else if (p[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
            }
            else if (p[0] == "Checklist")
            {
                var g = new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[5]), int.Parse(p[6]));
                g._completed = int.Parse(p[4]);
                _goals.Add(g);
            }
        }
        Console.Clear();
    }
}
