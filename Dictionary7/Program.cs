namespace Dictionary7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");

            var str = Console.ReadLine().Split(' ');

            Dictionary<string, int> map = new();

            foreach (var s in str)
            {
                if (map.ContainsKey(s))
                    map[s] += 1;
                else
                    map[s] = 1;
            }

            var max = map.Max(s => s.Value);

            foreach (var item in map)
            {
                if (item.Value == max)
                    Console.WriteLine($"Максимальное значение у {item.Key} {item.Value}");
                else
                    Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
