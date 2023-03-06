
    int[] duplicate = new int[10];
int count = 0;


    Console.WriteLine("Enter 10 values");
for (int i = 0; i< 10; i++)
{
    duplicate[i] = Convert.ToInt32(Console.ReadLine());

}
int[] unique = duplicate.Distinct().ToArray();

for (int a = 0; a < unique.Length-1; a++)
{
    count++;

}
Console.WriteLine("Count of duplicates is " + (10 - count) );
