//1.Write a program to accept 10 numbers from user and display it’s sum

using System;					
public class Program
{
public static void Main()
{
int i;
int x;
int sum = 0;
for(i =1; i<= 10 ; i++)
{
Console.WriteLine("Enter " + i + " number");
x = Convert.ToInt16(Console.ReadLine());
sum += x;
}
Console.WriteLine(sum);
}
}
