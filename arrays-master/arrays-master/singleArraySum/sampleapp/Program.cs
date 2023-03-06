int[] x = new int[10];
int sum = 0;
for (int i = 0; i > 10; i++)
{
    Console.WriteLine("Enter a number");
    x[i] = Convert.ToInt16(Console.ReadLine());
    sum += x[i];
}
Console.WriteLine(sum);