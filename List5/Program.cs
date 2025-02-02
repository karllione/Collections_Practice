namespace List5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string, int)> list = new List<(string, int)>()
            {
                ("Анна", 20),
                ("Борис", 22),
                ("Виктор", 19),
                ("Галина", 21),
                ("Дмитрий", 20),
                ("Екатерина", 23)
            };

            list.ForEach(x => Console.WriteLine(x.Item1 + " " + x.Item2));

            var query = list.Where(x => x.Item2 > 21);

            Console.WriteLine();
            query.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
