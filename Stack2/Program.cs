namespace Stack2
{
    class TextEditor
    {
        Stack<string> st = new Stack<string>();
        public void Write(string text)
        {
            st.Push(text);
        }
        public void Undo()
        {
            st.Pop();
        }
        public string GetText()
        {
            Stack<string> st2 = new Stack<string>(st);
            return string.Join("", st2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            editor.Write("Hello");
            editor.Write(" World!");
            editor.Write(" Oh yes");
            Console.WriteLine(editor.GetText());
            editor.Undo();
            Console.WriteLine(editor.GetText());
        }
    }
}
