using System.Reflection;
using System;
using System.Reflection.Emit;

class product
{
    public string productId { get; set; }
    public string productName { get; set; }

    public string brand { get; set; }

    public int quantity { get; set; }

    public int price { get; set; }
}

class program
{


    static void seedData(List<product> prop)
    {
        prop.Add(new product { productId = "P001", productName = "Laptop", brand = "Dell", quantity = 5, price = 35000 });
        prop.Add(new product { productId = "P002", productName = "Camera", brand = "Canon", quantity = 8, price = 28500 });
        prop.Add(new product { productId = "P003", productName = "Tablet", brand = "Lenovo", quantity = 4, price = 15000 });
        prop.Add(new product { productId = "P004", productName = "Mobile", brand = "Apple", quantity = 9, price = 65000 });
        prop.Add(new product { productId = "P005", productName = "Earphones", brand = "Boat", quantity = 2, price = 1500 });

    }

    public static void Main(string[] args)
    {
        List<product> prop = new List<product>();
        seedData(prop);
        //Write the code to retrieve the Product names from Product List where Price is between 20000 to 40000.
        var q = from p in prop where p.price >= 20000 && p.price <= 40000 select p.productName;
        foreach (var item in q)
        {
            Console.WriteLine(item);
        }

        //Write the code for retrieving the data from Product List where ProductName contains letter a.
        var w = from p in prop where p.productName.Contains('A') || p.productName.Contains('a') select p;
        foreach ( var item in w)
        {
            Console.WriteLine($"{item.productId} , {item.productName}, {item.brand}, {item.quantity}, {item.price} ");
        }

        //Write the code for retrieving all data from Product List arranged in alphabetical order based on ProductName.
        var v = from p in prop orderby p.productName select p;
        foreach (var item in v)
        {
            Console.WriteLine($"{item.productId} , {item.productName}, {item.brand}, {item.quantity}, {item.price} ");
        }

        //Write the code for retrieving the highest Price from Product List.
        var m = prop.Find(x => x.price == prop.Max(x => x.price));
        Console.WriteLine($"{m.productId} , {m.productName}, {m.brand}, {m.quantity}, {m.price} ");

        //Write the code to check whether the Product with ProductId P003 exists in Product List or not.
        //The output should be a Boolean value.

        bool exists = prop.Any(p => p.productId == "P003");

        Console.WriteLine(exists);
    }
}


