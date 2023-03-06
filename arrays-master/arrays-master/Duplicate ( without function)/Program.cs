class program
{
public static void Main(string[]args)
{

int[] duplicate = new int[10];
int count = 0;


System.Console.WriteLine("Enter 10 values");

for (int i = 0; i< 10; i++)
{
duplicate[i] = System.Convert.ToInt32(Console.ReadLine());


}

for (int a = 0; a < 10; a++)
{ 
for (int b = a+1; b <10; b++) 
{
    if (duplicate[a] == duplicate[b])
	{ 
	count=count+1;
	break;
	}

}
}


System.Console.WriteLine("Count of duplicates is " + count);
}
}