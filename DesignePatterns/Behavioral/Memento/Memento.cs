namespace DesignePatterns.Behavioral.Memento
{
    public class TextMemento
    {
        public string State { get; }

        public TextMemento(string state)
        {
            State = state;
        }
    }
    public class TextEditor
    {
        private string _content;

        public void SetText(string text) => _content = text;
        public string GetText() => _content;

        public TextMemento Save() => new TextMemento(_content);

        public void Restore(TextMemento memento)
            => _content = memento.State;
    }
    class History
    {
        private Stack<TextMemento> _history = new();

        public void Save(TextEditor editor)
            =>_history.Push(editor.Save());

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0)
                editor.Restore(_history.Pop());
        }
    }
}
