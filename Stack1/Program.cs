namespace Stack1
{
    internal class Program
    {
        static bool IsBalanced(string s)
        {
            Stack<char> st = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    st.Push(c);
                }
                else if(c == ')' || c == '}' || c == ']')
                {
                    if(st.Count == 0)
                    {
                        return false;
                    }
                    char last = st.Pop();
                    if (last != pairs[c])
                        return false;
                }
            }

            return st.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanced("({[]})")); // True
            Console.WriteLine(IsBalanced("({[)]}")); // False
            Console.WriteLine(IsBalanced("{[()]}")); // True
            Console.WriteLine(IsBalanced("{[(])}")); // False
            Console.WriteLine(IsBalanced("{{[[(())]]}}")); // True
        }
    }
}
