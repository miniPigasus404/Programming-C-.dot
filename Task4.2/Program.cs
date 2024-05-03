namespace Task4._2
{
    struct Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Price}";
        }
    }
    internal class Program
    {
        static void TotalPrice(ILookup<string, Product> lookup)
        {
            int sum = 0;
            foreach (var product in lookup)
            {
                foreach (var el in product)
                {
                    Console.WriteLine(el.ToString());
                    sum += el.Price;
                }
                Console.WriteLine($"{product.Key} {sum}");
                sum = 0;
            }
        }
        static void Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
            products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
            products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
            products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
            products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
            ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
            TotalPrice(lookup);
            Console.ReadKey();

        }
    }
}
