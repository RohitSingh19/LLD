public class TextEditor
{
    private string _text = "";
    private string _backup = "";

    public void AddText(string text)
    {
        _backup = _text;  // Save current state for undo
        _text += text;
        Console.WriteLine($"Text after adding: {_text}");
    }

    public void RemoveText(int length)
    {
        _backup = _text;  // Save current state for undo
        if (length <= _text.Length)
        {
            _text = _text.Substring(0, _text.Length - length);
        }
        Console.WriteLine($"Text after deleting: {_text}");
    }

    public void RestoreText()
    {
        _text = _backup;
        Console.WriteLine($"Text after undo: {_text}");
    }

    public string GetText()
    {
        return _text;
    }
}
