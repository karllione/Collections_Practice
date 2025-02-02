namespace List4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 15, 42, 45, 7, 23, 42, 8, 3, 19, 42, 4, 5 };

            list.ForEach(x => Console.Write(x + " "));

            list.RemoveAll(x => (x % 3 == 0) && (x % 5 == 0));
            Console.WriteLine();
            list.ForEach(x => Console.Write(x + " "));
        }
    }
}
