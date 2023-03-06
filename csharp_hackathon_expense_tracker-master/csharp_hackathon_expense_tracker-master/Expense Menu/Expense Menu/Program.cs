using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

class Menu
{
    public string title { get; set; }
    public string description { get; set; }

    public double amount { get; set; }

    public DateTime date { get; set; }



}

class Menu1
{
    List<Menu> m = new List<Menu>();
    double b = 0;

    // this method gets user input of title, description and amount and adds them to the list. Date is auto generated based on time of input
    //if amount is less than 0, it will inform user that expense is added. If more than 0, then income added. 
    public void transaction() 
    {
        Console.WriteLine("Enter title of transaction");
        string x = Console.ReadLine();
        Console.WriteLine("Enter transaction description");
        string y = Console.ReadLine();
        Console.WriteLine("Enter transaction amount : Expense as negative and Income as positive");
        double z = Convert.ToDouble(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        m.Add(new Menu { title = x, description = y, amount = z, date = currentDate });
      
        
        if (z < 0)
        {
            Console.WriteLine("Expense added");
        }
        else
            Console.WriteLine("Income Added");

       
        // this returns the balance (b) by adding in the latest addition of transaction to previous balance amount
        for (int i = m.Count - 1; i < m.Count; i++)
        {
            b += m[i].amount;
        }
       
        //balance is always overwritten in file when balance is updated. 
        string balance = $"Avaliable balance is ${b}";
        File.WriteAllText("file.txt", balance);

    }

    public void viewExpense()
    {
        //querying only the expenses which are negative values. Hence less than 0
        var query = m.Where(x => x.amount < 0);
        foreach (var x in query)
        {
            Console.WriteLine($"Title is {x.title} \t Description is {x.description} \t Expense is ${x.amount}\t  Date of transaction is {x.date}");

        }
    }

    public void viewIncome()
    {   //querying only the income which are positive values. Hence more than 0
        var query = m.Where(x => x.amount > 0);
        foreach (var x in query)
        {
            Console.WriteLine($"Title is {x.title} \t Description is {x.description} \t Income is ${x.amount}\t  Date of transaction is {x.date}");

        }

    }

    public void checkBalance()
    {

        // old code of only creating file, generating balance and writing to file ONLY when option 4 is called
        /*string filename = "file.txt";
        File.Create(filename).Dispose();  

        List<double> amounts = m.Select(x => x.amount).ToList();
        double b = 0;
        foreach(var amount in amounts)
        {
            b += amount;
        }*/


        
        
        string fileContents = File.ReadAllText("file.txt");
        
        Console.WriteLine(fileContents);

    }


    static void Main(string[] args)
    {

        Menu1 m = new Menu1();
        string filename = "file.txt";
        File.Create(filename).Dispose();

        do
        {
            Console.WriteLine("Welcome to the system \n Select Option number \n 1.Add transaction \n 2.View expenses \n 3.View income \n 4 Check balance avaliable");
            int a = Convert.ToInt32(Console.ReadLine());
            // switch case based on user input
            switch (a)
            {
                case 1:
                 m.transaction();
                 
                    break;
               
                case 2:
                    m.viewExpense();
                    break;

                case 3:
                    m.viewIncome();
                    break;

                case 4:
                    m.checkBalance();
                    break;

                default:
                    Console.WriteLine("Wrong choice entered");
                    break;

            }

            Console.WriteLine("Do you wish to continue? Y or N");

           // will continue to loop as long as user inputs in Y or y 

        } while (Console.ReadLine().ToLower() == "y");

    }

}

