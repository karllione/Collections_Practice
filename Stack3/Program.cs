namespace Stack3
{
    internal class Program
    {
        public static string ReverseString(string str)
        {
            string s = "";
            Stack<char> st = new Stack<char>();

            foreach(char c in str)
            {
                st.Push(c);
            }
            while(st.Count > 0)
            {
                s += st.Pop();
            }
            return s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(ReverseString("Stack"));
        }
    }
}
