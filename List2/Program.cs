namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "hello", "world", "hello", "average" };
            var map = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if (map.ContainsKey(item))
                {
                    map[item] += 1;
                }
                else
                {
                    map[item] = 1;
                }
            }
            var max = map.Max(x => x.Value);

            foreach (var pair in map)
            {
                if (pair.Value == max)
                    Console.WriteLine($"Самое часто встречающееся слово в списке: {pair.Key}");
            }
        }
    }
}
