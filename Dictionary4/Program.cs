namespace Dictionary4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map1 = new()
            {
                { 1, "a"},
                { 2, "b" },
                { 3, "c" }
            };
            Dictionary<string, int> map2 = new();

            foreach (var pair in map1)
            {
                Console.WriteLine($"{pair.Key} , {pair.Value}");
            }

            foreach (var pair in map1)
            {
                map2.Add(pair.Value, pair.Key);
            }
            Console.WriteLine();
            foreach (var pair in map2)
            {
                Console.WriteLine($"{pair.Key} , {pair.Value}");
            }
        }
    }
}
