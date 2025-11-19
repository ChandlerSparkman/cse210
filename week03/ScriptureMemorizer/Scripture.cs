public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private bool _isCompletelyHidden;
    Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide + 1; i++)
        {
            Random randomGenerator = new Random();
            int randomChoice = random.Next(_words.Count);
            Word word = _words[randomChoice];
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        bool hiddenSoFar = true;
        foreach (Word word in _words)
        {
            string individualWord = word.GetDisplayText();
            text = text + individualWord + " ";
            bool wordHidden = word.isHidden();
            if (wordHidden == false)
            {
                hiddenSoFar = false;
            }
        }

        _isCompletelyHidden = hiddenSoFar;
        string displayText = $"{_reference.GetDisplayText()}\n{text}";
        return displayText;
    }

    public bool getHiddenState()
    {
        return _isCompletelyHidden;
    }
}