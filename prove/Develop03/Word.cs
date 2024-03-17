public class Word
{
    public string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string result = "";
            foreach (char letter in _word)
            {
                result += "_";
            }
            return result;
        }
        else
        {
            return _word;
        }
    }
}