namespace Dictionary9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<string, int>()
            {
                { "apple", 4},
                { "cherry", 2},
                { "grape", 8},
                { "orange", 10},
                { "banana", 1}
            };

            var query = from p in map
                        orderby p.Value descending
                        select p;

            foreach (var pair in query)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
