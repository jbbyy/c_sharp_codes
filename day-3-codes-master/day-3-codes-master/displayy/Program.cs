// 2. write a program to accept 10 numbers from user and display largest number

using System;					
public class Program
{
public static void Main()
{
int i;
int x;
int a = 0;
for(i =1; i<= 10 ; i++)
{
Console.WriteLine("Enter " + i + " number");
x = Convert.ToInt16(Console.ReadLine());
if(x > a)
{
a = x;
Console.WriteLine("largest number is " + a);
}
else
{
Console.WriteLine("largest number is " + a);
}
}

}
}
