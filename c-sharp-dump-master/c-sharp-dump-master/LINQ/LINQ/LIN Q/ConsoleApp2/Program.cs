namespace ConsoleApp2
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> prop = new List<Products>();
            prop.Add(new Products { Id = 10, Name = "A", Email = "A@gmail.com", Age = 26 });
            prop.Add(new Products { Id = 2, Name = "B", Email = "B@gmail.com", Age = 32 });
            prop.Add(new Products { Id = 9, Name = "C", Email = "C@gmail.com", Age = 40 });
            prop.Add(new Products { Id = 4, Name = "D", Email = "D@gmail.com", Age = 44 });
            prop.Add(new Products { Id = 5, Name = "E", Email = "E@gmail.com", Age = 27 });
            prop.Add(new Products { Id = 6, Name = "F", Email = "F@gmail.com", Age = 29 });
            prop.Add(new Products { Id = 7, Name = "G", Email = "G@gmail.com", Age = 32 });
            prop.Add(new Products { Id = 3, Name = "H", Email = "H@gmail.com", Age = 58 });
            prop.Add(new Products { Id = 9, Name = "I", Email = "I@gmail.com", Age = 43 });
            prop.Add(new Products { Id = 1, Name = "J", Email = "J@gmail.com", Age = 46, });

            // create LINQ Query
            var query = prop.Where(x => x.Name.ToLower().Contains('a'));

            
        }
    }
}