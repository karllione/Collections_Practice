namespace Dictionary8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map1 = new()
            {
                { "apple", 3},
                { "banana", 2},
                { "cherry", 5}
            };
            Dictionary<string, int> map2 = new()
            {
                { "banana", 7},
                { "cherry", 1},
                { "grape", 9}
            };

            Dictionary<string, int> result = MergeDictionaries(map1, map2);

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
        static Dictionary<string, int> MergeDictionaries(
            Dictionary<string, int> m1, Dictionary<string, int> m2)
        {
            Dictionary<string, int> result = new();
            foreach (var pair in m1)
            {
                if (m2.ContainsKey(pair.Key))
                    result[pair.Key] = pair.Value;
            }

            return result;
        }
    }
}
