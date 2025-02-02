namespace Dictionary5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> warehouse1 = new Dictionary<string, int>
            {
                { "Apple", 10 },
                { "Banana", 5 },
                { "Orange", 7 }
            };

            Dictionary<string, int> warehouse2 = new Dictionary<string, int>
            {
                { "Banana", 8 },
                { "Orange", 3 },
                { "Grapes", 15 }
            };

            Dictionary<string, int> merged = MergedWareHouse(warehouse1, warehouse2);

            foreach (var pair in merged)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
        static Dictionary<string, int> MergedWareHouse(Dictionary<string, int> w1, Dictionary<string, int> w2)
        {
            Dictionary<string, int> mergedWareHouses = new(w1);

            foreach (var pair in w2)
            {
                if (mergedWareHouses.ContainsKey(pair.Key))
                {
                    mergedWareHouses[pair.Key] += pair.Value;
                }
                else
                {
                    mergedWareHouses[pair.Key] = pair.Value;
                }
            }

            return mergedWareHouses;
        }
    }
}
