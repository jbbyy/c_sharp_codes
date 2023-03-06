//Write a program to create a list of 10 products and find all the products where quantity is greater than 5.
//And display ID/Name/Brand/Quantity/Price 
class Products : IComparable<Products> // need to implement comparable method in model class, method that is present in interface for sorting 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }

    public int CompareTo(Products? p)  // for sorting, to auto implement interface method, ctl . at the Icomparable class
    {
        if (this.Quantity > p.Quantity)
        {
            return 1;
        }
        else if (this.Quantity < p.Quantity)
        {
            return -1;
        }
        else
            return 0; 
    }
}


class MySortbyPrice : IComparer<Products> 
    // sorting algo in a separate class so now can call that class instance and use this in other classes. 
{
    public int Compare(Products? x, Products? y)
    {
        if (x.Price > y.Price)
        {
            return 1;
        }
        else if (x.Price < y.Price)
        {
            return -1;
        }
        else
            return 0;
    }
}

class program
{
    public static void Main(string[] args)
    {
        List<Products> prop = new List<Products>();
        prop.Add(new Products { Id = 1, Name = "Cup", Brand = "no brand", Quantity = 6, Price = 5 });
        prop.Add(new Products { Id = 2, Name = "plate", Brand = "no brand", Quantity = 2, Price = 10 });
        prop.Add(new Products { Id = 3, Name = "spoon", Brand = "ikea", Quantity = 10, Price = 2 });
        prop.Add(new Products { Id = 4, Name = "bowl", Brand = "ikea", Quantity = 4, Price = 4 });
        prop.Add(new Products { Id = 5, Name = "spoon", Brand = "no brand", Quantity = 7, Price = 2 });
        prop.Add(new Products { Id = 6, Name = "cup", Brand = "ikea", Quantity = 9, Price = 7 });
        prop.Add(new Products { Id = 7, Name = "mug", Brand = "tablematters", Quantity = 2, Price = 3 });
        prop.Add(new Products { Id = 8, Name = "spoon", Brand = "ikea", Quantity = 5, Price = 2 });
        prop.Add(new Products { Id = 9, Name = "mug", Brand = "tablematters", Quantity = 3, Price = 8 });
        prop.Add(new Products { Id = 10, Name = "plate", Brand = "tablematters", Quantity = 6, Price = 2 });
        prop.Sort(); // to call the sorting method. 

        foreach (Products x in prop)
        {

            if (x.Quantity > 5)
            {
                Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Brand is {x.Brand}, Quantity is {x.Quantity} and price is {x.Price}");
            }
        }

    }
}
