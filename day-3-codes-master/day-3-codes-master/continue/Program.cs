//5. Accept a number from user and ask user to continue or not. Take another number or exit program and display sum of all numbers. 
using System;					
public class Program
{
public static void Main()
{
int x;
int sum = 0;
string a;

do
{
Console.WriteLine("Enter a number");
x = Convert.ToInt16(Console.ReadLine());
sum = sum + x;
Console.WriteLine("Do you have anymore items? (Y or N)");
a = Console.ReadLine();
} 
while(a =="Y");
Console.WriteLine(sum);
}
}
