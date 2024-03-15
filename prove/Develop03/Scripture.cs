public class Scripture()
{
    private Reference _reference;
    private string _text;
    private List<string> _words;

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
    private List<string> CreateWordsList()
    {
        string[] words = _text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return new List<string>(words);
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words)}";
    }
}