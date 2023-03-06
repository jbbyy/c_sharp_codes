using System.Security.Cryptography.X509Certificates;

int[] ascending = new int[10];
int temp;



Console.WriteLine("Enter 10 values");
for (int i = 0; i < 10; i++)
{
    ascending[i] = Convert.ToInt32(Console.ReadLine());

}
Array.Sort(ascending);

for (int c = 0; c < 10; c++)
{
    for( int j = 0; j < 9; j++)
    {
        if (ascending[j]> ascending[j + 1])
        {
            temp = ascending[j+1];
            ascending[j+1] = ascending[j];
              ascending[j] = temp;

        }
    }
    Console.WriteLine(ascending[c]);
}

