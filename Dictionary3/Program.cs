namespace Dictionary3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new();

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            var words = text.ToLower().Split(' ');

            foreach (string str in words)
            {
                if (map.ContainsKey(str))
                    map[str] += 1;
                else
                    map[str] = 1;
            }

            foreach (var pair in map)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}
