namespace Dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово или текст: ");
            string str = Console.ReadLine();

            Dictionary<char, int> map = new();

            foreach (var c in str)
            {
                map[c] = map.ContainsKey(c) ? ++map[c] : 1;
            }

            foreach (var pair in map)
                Console.WriteLine($"{pair.Key} = {pair.Value}");
        }
    }
}
