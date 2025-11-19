public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public string GetDisplayText()
    {
        string display;
        if (_hidden == true)
        {
            display = new string('_', _word.Length);
        }
        else
        {
            display = _word;
        }

        return display;
    }
    
    public bool isHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}