namespace List7
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product(string Name, string Category, double Price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Product>> categories = new Dictionary<string, List<Product>>();
            List<Product> products = new List<Product>()
            {
                new Product("Ноутбук Lenovo", "Электроника", 75000),
                new Product("Смартфон Samsung", "Электроника", 45000),
                new Product("Мышь Logitech", "Компьютерные аксессуары", 600),
                new Product("Клавиатура HyperX", "Компьютерные аксессуары", 5000),
                new Product("Монитор LG", "Электроника", 23000),
                new Product("Флешка Kingston 64GB", "Носители информации", 800),
                new Product("Внешний SSD 1TB", "Носители информации", 12000),
                new Product("Кофемашина Philips", "Бытовая техника", 35000),
                new Product("Пылесос Dyson", "Бытовая техника", 55000),
                new Product("Гитара Fender", "Музыкальные инструменты", 90000),
                new Product("Наушники Sony", "Аудиотехника", 18000),
                new Product("Микрофон Blue Yeti", "Аудиотехника", 12000)
            };

            var query = from p in products
                        where p.Price > 1000
                        orderby p.Name
                        select new
                        {
                            Name = p.Name,
                            Category = p.Category.ToUpper(),
                            Price = p.Price
                        };

            foreach (var q in query)
            {
                Console.WriteLine($"Category {q.Category} | Price {q.Price}");
            }

            foreach (var q in query)
            {
                if (!categories.ContainsKey(q.Category))
                {
                    categories[q.Category] = new List<Product>();
                }
                categories[q.Category].Add(new Product(q.Name, q.Category, q.Price));
            }
            Console.WriteLine();
            foreach (var c in categories)
            {
                Console.WriteLine($"Category {c.Key}: ");
                foreach (var t in c.Value)
                {
                    Console.WriteLine($"{t.Name} | {t.Price}");
                }
            }
        }
    }
}
