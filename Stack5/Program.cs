namespace Stack5
{
    internal class Program
    {
        static bool IsPalindrome(string str)
        {
            Stack<char> st = new Stack<char>();

            for(int i = 0; i < str.Length / 2; i++)
            {
                st.Push(str[i]);
            }

            int start = str.Length % 2 == 0 ? (str.Length / 2) : (str.Length / 2) + 1;

            for(int i = start; i < str.Length; i++)
            {
                if(st.Pop() != str[i])
                {
                    return false;
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("level"));
            Console.WriteLine(IsPalindrome("hello"));
        }
    }
}
