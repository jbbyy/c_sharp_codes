class program
{
public static void Main(string[]args)
{

//Write a program to take amount, rate of interest, number of years and calculate simple interest. 

double a, b, c, simpleInterest;
System.Console.WriteLine("Please enter an amount");
a = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter interest rate");
b = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter number of years");
c = Convert.ToDouble(System.Console.ReadLine());
simpleInterest = a*(b/100)*c;
System.Console.WriteLine("Total interest is $" + simpleInterest );

}
}