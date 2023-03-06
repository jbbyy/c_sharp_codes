/* Create a program for managing products 

5 options 
Add product 
Find product 
Get All products
Update product 
Delete product 

Properties
ProductId, ProductName, Brand, Quanity, Price  */

class Products
{
    public string productId { get; set; }
    public string productName { get; set; }
    public string brand { get; set; }
    public int quantity { get; set; }
    public int price { get; set; }

}

class Menu
{

    List<Products> prop = new List<Products>();
    public void addProduct()
    {
        Console.WriteLine("Enter product ID");
        try
        {
            string x = Console.ReadLine();
            Console.WriteLine("Enter product name");
            string y = Console.ReadLine();
            Console.WriteLine("Enter brand");
            string z = Console.ReadLine();
            Console.WriteLine("Enter quantity");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price");
            int p = Convert.ToInt32(Console.ReadLine());

            //check for duplicate value and prompt user to reenter another ID
            var dup = prop.Find(d => d.productId == x);
            if(dup != null)
            {
                Console.WriteLine("Duplicate product Id, please enter another product Id");
                string d = Console.ReadLine();
                prop.Add(new Products { productId = d, productName = y, brand = z, quantity = o, price = p });
            }
            else
                prop.Add(new Products { productId = x, productName = y, brand = z, quantity = o, price = p });


            //Print newest addition
            for (int i = prop.Count - 1; i < prop.Count; i++)
            {
                Console.WriteLine($"Newest product addition : ID is {prop[i].productId}, Name is {prop[i].productName}, brand is {prop[i].brand}, quantity is {prop[i].quantity}, price is {prop[i].price}");
            }

        }
        catch(Exception)
        {
            Console.WriteLine("Please input a string data type for productID, productName and brand. And an int data type for quantity and price");
        }

    }

    public void findProduct()
    {
        Console.WriteLine("Enter product ID");
         string B = Console.ReadLine();

       var query = prop.Find(x=>x.productId == B);
        if (query != null)
        {
            Console.WriteLine($"ID is {query.productId}, Name is {query.productName}, brand is {query.brand}, quantity is {query.quantity}, price is {query.price}");
        }
        else
            Console.WriteLine("Unable to find product");
        

    }

    public void getAllProduct()
    {
        foreach (var x in prop)
        {
                Console.WriteLine($"ID is {x.productId}, Name is {x.productName}, brand is {x.brand}, quantity is {x.quantity}, price is {x.price}");  
        }
    }

    public void updateProduct()
    { 
        try
        {
            Console.WriteLine("Enter product Id to update");
            string c = Console.ReadLine();
            var query = prop.Find(x => x.productId == c);
            if (query != null)
            {
                Console.WriteLine("Enter product name");
                query.productName = Console.ReadLine();
                Console.WriteLine("Enter brand");
                query.brand = Console.ReadLine();
                Console.WriteLine("Enter quantity");
                query.quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter price");
                query.price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Updated product details : ID is {query.productId}, Name is {query.productName}, brand is {query.brand}, quantity is {query.quantity}, price is {query.price}");
            }
            else
                Console.WriteLine("Product does not exist, unable to perform undate");
                
            
        }
        catch (Exception)
        {
            Console.WriteLine("Please input a string data type for productID, productName and brand. And an int data type for quantity and price");
        }

    }

    //This is deleteProduct method for deleting theproduct information from list
    public void deleteProduct()
    {
        Console.WriteLine("Enter product Id to remove");
        string r = Console.ReadLine();

        var query = prop.Find(x => x.productId == r);

        if (query != null)
        {
            prop.Remove(query);
        }

        Console.WriteLine("Current list of products");
        foreach (var x in prop)
        {
            Console.WriteLine($"ID is {x.productId}, Name is {x.productName}, brand is {x.brand}, quantity is {x.quantity}, price is {x.price}");
        }

    }


    static void Main(string[]args)
    { 
        Menu m = new Menu();
        do
        {
            Console.WriteLine("Welcome to the system \n Select Option number \n 1.Add product details \n 2.Find product details \n 3.Get all products\n 4.Update product \n 5.Delete product");
            int a = Convert.ToInt32(Console.ReadLine());
            
            switch (a)
            {
                case 1: 
                    
                    m.addProduct();
                    break;

                case 2:
                    m.findProduct();
                    break;
                
                case 3:
                    m.getAllProduct();
                    break;
                
                case 4:
                    m.updateProduct();
                    break;
                case 5: 
                    m.deleteProduct();
                    break;


            }
            Console.WriteLine("Do you wish to continue using the program? Y or N");
          
        } while(Console.ReadLine() == "Y") ;

    }

}