namespace Dictionary6
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
        public override string ToString()
        {
            return $"[{Name} {Price}]";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product("Laptop", "Electronics", 1000),
                new Product("Phone", "Electronics", 500),
                new Product("Table", "Furniture", 200)
            };

            var query = products.GroupBy(x => x.Category).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var i in query)
            {
                Console.Write($"{i.Key}: ");
                foreach (var item in i.Value)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}
