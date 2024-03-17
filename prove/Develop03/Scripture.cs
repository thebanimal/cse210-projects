public class Scripture()
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text) : this()
    {
        _reference = reference;
        _text = text;
        _words = CreateWordsList();
    }

    public void SetText(string text)
    {
        _text = text;
        _words = CreateWordsList();
    }
    private List<Word> CreateWordsList()
    {
        string[] words = _text.Split(' ');
        List<Word> wordList = new List<Word>();
        foreach (string w in words)
        {
            Word word = new Word(w);
            wordList.Add(word);
        }
        return wordList;
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words)}";
    }
}