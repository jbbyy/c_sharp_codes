/* To the power of
Given two integers, write a method that returns first number raised to the power of second one.
Expected input and output
ToThePowerOf(-2, 3) → -8
ToThePowerOf(5, 5) → 3125*/

using System.Diagnostics.CodeAnalysis;

int powerOf(int x, int y)
{
    int sum = 1;
    while (y > 0)
    {
        sum = sum * x;
        y--;
    }
    return sum;
}

Console.WriteLine(powerOf(-2, 3));
Console.WriteLine(powerOf(5, 5));
