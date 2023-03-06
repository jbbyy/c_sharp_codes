class program
{
public static void Main(string[]args)
{
//Write a program to take a number from user and calculate its cube 

int x, result;
System.Console.WriteLine("Please enter a number");
x = Convert.ToInt16(System.Console.ReadLine());
result = x*x*x;
System.Console.WriteLine("Cube of " + x + " is " + result);
}
}
