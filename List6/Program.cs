namespace List6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 3, 7, 1, 9, 5 };

            for (int i = numbers.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (j == i)
                    {
                        numbers.Remove(numbers[j]);
                    }
                }
            }

            numbers.ForEach(x => Console.Write(x + " "));
        }
    }
}
