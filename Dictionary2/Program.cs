namespace Dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new()
            {
                { "Alice Johnson", "+1-202-555-0143" },
                { "Bob Smith", "+1-202-555-0176" },
                { "Charlie Davis", "+44-7911-123456" },
                { "Diana Moore", "+49-1521-9876543" },
                { "Ethan Wilson", "+33-612-345-678" }
            };

            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Вывести список");
                Console.WriteLine("2. Добавить контакт в список");
                Console.WriteLine("3. Отредактировать контакт");
                Console.WriteLine("4. Удалить контакт");
                Console.WriteLine("0. Выйти");

                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                switch (number)
                {
                    case 1:
                        {
                            foreach (var pair in contacts)
                            {
                                Console.WriteLine($"{pair.Key}: {pair.Value}");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите имя и номер: ");
                            string str = Console.ReadLine();

                            var line = str.Split(' ');

                            contacts.Add(line[0], line[1]);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Введите ключ: ");
                            string key = Console.ReadLine();
                            Console.Write("Введите значение: ");
                            string value = Console.ReadLine();

                            contacts[key] = value;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите ключ на удаление: ");
                            string key = Console.ReadLine();

                            contacts.Remove(key);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого варианта нет.");
                            break;
                        }
                }
            }
        }
    }
}
