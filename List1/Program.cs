namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>() { 2, 1, 4, 3, 4, 5 };
            var list2 = new List<int>() { 8, 6, 5, 6, 7, 8 };

            var result = list1.Union(list2).OrderBy(p => p).Distinct().ToList();

            Console.Write("Первый список: ");
            list1.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Второй список: ");
            list2.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Результат: ");
            result.ForEach(x => Console.Write(x + " "));
        }
    }
}
