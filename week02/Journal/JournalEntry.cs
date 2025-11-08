public class JournalEntry
{
    public string _date = "";
    public string _prompt = "";
    public string _content = "";


    public string saveDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}