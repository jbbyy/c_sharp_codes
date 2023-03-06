

//Write a program to accept a year from the user and display if it’s a leap year or not

class program
{
public static void Main(string[]args){
int x;
System.Console.WriteLine("Please enter a year");
x = Convert.ToInt16(System.Console.ReadLine());
if(x%4 == 0)
{
if((x%100== 0) && (x%400 == 0))
{
System.Console.WriteLine(x + " is a leap year");
}
else if ((x%100 == 0) && (x%400 != 0))
{
System.Console.WriteLine(x + " is not a leap year");
}
else
{
System.Console.WriteLine(x + " is a leap year");
}
}
else
{
System.Console.WriteLine(x + " is not a leap year");
}

}
}
