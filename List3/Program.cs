namespace List3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N - конец последовательности Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();
            int j = 1;
            for (int i = 1; i <= n; i += j)
            {
                j = i - j;
                list.Add(j);
            }

            list.ForEach(x => Console.Write(x + " "));
        }
    }
}
