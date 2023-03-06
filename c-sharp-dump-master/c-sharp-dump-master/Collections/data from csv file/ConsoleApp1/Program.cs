//Write a program to take data from csv file, store it somewhere.
//Get input from user “ Enter customer ID” , display details of that customer.

using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;

class details
{
    public string CustomerId { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

}
public class program1
{
    public static void Main(string[] args)
    {

        //List<details> d = new List<details>();
        //string[] b = File.ReadAllLines(@"D:\Coding practice\Collections\Data.csv"); 
        ////opens reads store into an array and closes the stream. Array is a temp storage
        //for (int i = 1; i < b.Length; i++)
        //{
        //    string[] c = b[i].Split(",");
        //    d.Add(new details { CustomerId = c[0], CompanyName = c[1], ContactName = c[2], ContactTitle = c[3], Address = c[4], City = c[5] });
        //}

        //Console.WriteLine("Enter CustomerId");
        //String x = Console.ReadLine();
        //foreach (details a in d)
        //{
        //    if (x == a.CustomerId)
        //    {
        //        Console.WriteLine($"CustomerId is {a.CustomerId}, Company Name is {a.CompanyName}, Contact Name is {a.ContactName}, Address is {a.Address} and City is {a.City}");
        //    }
        //}
        string s1 = "nurpar";
        string s2;
        s2 = s1.Insert(7, "mudai");
        Console.WriteLine(s2);

    }
}
