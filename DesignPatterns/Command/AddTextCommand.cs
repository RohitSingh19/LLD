using LLD.DesignPatterns.Command;

public class AddTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _text;

    public AddTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.AddText(_text);
    }

    public void Undo()
    {
        _editor.RemoveText(_text.Length);
    }
}

public class DeleteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _length;

    public DeleteTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
    }

    public void Execute()
    {
        _editor.RemoveText(_length);
    }

    public void Undo()
    {
        _editor.RestoreText();
    }
}
