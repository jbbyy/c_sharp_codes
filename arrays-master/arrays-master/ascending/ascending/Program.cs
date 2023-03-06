int[] ascending = new int[10];



Console.WriteLine("Enter 10 values");
for (int i = 0; i < 10; i++)
{
    ascending[i] = Convert.ToInt32(Console.ReadLine());

}
Array.Sort(ascending);

for (int a = 0; a < 10; a++)
{
    Console.WriteLine(ascending[a]);

}
