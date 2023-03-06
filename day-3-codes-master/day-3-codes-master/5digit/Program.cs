//3.write a program to accept 5 digit number and display sum of all digits 

using System;					
public class Program
{
public static void Main()
{
int i, b, c;
int sum = 0;
Console.WriteLine("Enter a 5 digit number");
int x = Convert.ToInt16(Console.ReadLine());
for(i =1; i<= 5 ; i++)
{ 
b = x%10;
sum = sum + (x%10);
c = x/10;
x = c;

}
Console.WriteLine(sum);
}

}

