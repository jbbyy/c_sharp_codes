int[] reverse = new int[5];

Console.WriteLine("Enter 5 values");
for (int i = 0; i <= 4; i++)
{
   
    reverse[i] = Convert.ToInt32(Console.ReadLine());

}
for(int b =4; b >=0; b--)
{
    Console.WriteLine(reverse[b]);
}
