/* Create a list of employees which should have properties of ID int, Name string, email of string , age int 

10 records  

Display a message " welcome to the system" with options  

Find employee 

Add Employee  

List All Employees  

Arrange Employees data  

 

For 1, "Enter employee ID" Show employee details  

For 2, take input for all the details to be added  

"Enter id/name/email/age" add to list  

 

For 3, print the entire list  

For 4, Enter field name based on which to arrange  */


class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

}

class MySortbyId : IComparer<Products> 
{
    public int Compare(Products? x, Products? y)
    {
        if (x.Id > y.Id)
        {
            return 1;
        }
        else if (x.Id < y.Id)
        {
            return -1;
        }
        else
            return 0;
    }
}

class MySortbyName : IComparer<Products>
{
    public int Compare(Products? x, Products? y) // have to return either 0, -1, 1
    {
        return x.Name.CompareTo(y.Name);
       
        //return string.Compare(x.Name, y.Name);
         
    }
}

class MySortbyEmail : IComparer<Products>
{
    public int Compare(Products? x, Products? y)
    {
        int result = x.Email.CompareTo(y.Email);
        return result;

    }
}

class MySortbyAge : IComparer<Products>
{
    public int Compare(Products? x, Products? y)
    {
        if (x.Age > y.Age)
        {
            return 1;
        }
        else if (x.Age < y.Age)
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
        prop.Add(new Products { Id = 10, Name = "A",  Email= "A@gmail.com", Age= 26});
        prop.Add(new Products { Id = 2, Name = "B", Email = "B@gmail.com", Age = 32});
        prop.Add(new Products { Id = 9, Name = "C", Email = "C@gmail.com", Age = 40});
        prop.Add(new Products { Id = 4, Name = "D", Email = "D@gmail.com", Age = 44});
        prop.Add(new Products { Id = 5, Name = "E", Email = "E@gmail.com", Age = 27});
        prop.Add(new Products { Id = 6, Name = "F", Email = "F@gmail.com", Age = 29});
        prop.Add(new Products { Id = 7, Name = "G", Email = "G@gmail.com", Age = 32 });
        prop.Add(new Products { Id = 3, Name = "H", Email = "H@gmail.com", Age = 58});
        prop.Add(new Products { Id = 9, Name = "I", Email = "I@gmail.com", Age = 43 });
        prop.Add(new Products { Id = 1, Name = "J",Email = "J@gmail.com", Age = 46, });
        //prop.Sort(); to call the sorting method. 

        Console.WriteLine("Welcome to the system \n Select Option number \n 1.Find Employee \n 2.Add employee \n 3.List all employees\n 4.Arrange all employees");
       
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {

            Console.WriteLine("Enter employee ID");
            int B = Convert.ToInt32(Console.ReadLine());
            foreach (Products x in prop)
            {
                if (x.Id == B)
                {
                    Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                }
            }

        }
        else if (a == 2)
        {
            Console.WriteLine("Enter employee ID");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string y = Console.ReadLine();
            Console.WriteLine("Enter employee email");
            string z = Console.ReadLine();
            Console.WriteLine("Enter employee age");
            int o = Convert.ToInt32(Console.ReadLine());


            prop.Add(new Products { Id = x, Name = y, Email = z, Age = o });
            for(int i = prop.Count - 1; i < prop.Count; i++)
            {
                Console.WriteLine($"Newest employee addition : ID is {prop[i].Id}, Name is {prop[i].Name}, Email is {prop[i].Email}, Age is {prop[i].Age}");
            }
        }
        else if (a == 3)
        {
            foreach (Products x in prop)
            {
                {
                    Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                }

            }
        }
        else if (a ==4)
        {
            Console.WriteLine("Enter field to arrange by (Id, Name, Email or Age) ");
            switch (Console.ReadLine())
            {
                case "Id" :
                    prop.Sort(new MySortbyId());
                    foreach (Products x in prop)
                    {
                        {
                            Console.WriteLine($" ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                        }

                    }

                    break;

                case "Name":

                    prop.Sort(new MySortbyName());
                    foreach (Products x in prop)
                    {
                        {
                            Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                        }

                    }

                    break;

                case "Email":
                    prop.Sort(new MySortbyEmail());
                    foreach (Products x in prop)
                    {
                        {
                            Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                        }

                    }

                    break;

                case "Age":
                    prop.Sort(new MySortbyAge());
                    foreach (Products x in prop)
                    {
                        {
                            Console.WriteLine($"ID is {x.Id}, Name is {x.Name}, Email is {x.Email}, Age is {x.Age}");
                        }

                    }

                    break;
                   

            }

        }
        
    }
}
