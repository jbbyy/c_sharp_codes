//4. write a program to display single input, if input is even. Divide by 2. If odd, must be multiplied by 3 + 1 continue till you get 1. 

using System;					
public class Program
{
public static void Main()
{
int i, x;
Console.WriteLine("Enter a number");
x = Convert.ToInt16(Console.ReadLine());
do
{
if (x%2 ==0)
{
x = x/2;
Console.WriteLine(x);
}
else
{
x = (x*3) + 1;
Console.WriteLine(x);
}
i = x;
} 
while(i>1);

	
}
}
