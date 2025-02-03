namespace Stack4
{
    internal class Program
    {
        static string RemoveDuplicates(string str)
        {
            Stack<char> st = new Stack<char>();

            foreach(char c in str)
            {
                if(st.Count == 0 || st.Peek() != c)
                {
                    st.Push(c);
                }
            }
            return new string(st.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("aabbcc")); // abc
        }
    }
}
