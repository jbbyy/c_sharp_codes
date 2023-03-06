int a, b, c;
for (a = 1; a <= 5; a++)
{
    for (b = a; b <5; b++)
    {
        Console.Write(" "); 
    }

    for (c=1; c<a+1; c++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}

int d, e, f;
for (d = 1; d <=5; d++)
{
    for (e = d; e >=1; e--)
    {
        Console.Write(" ");
    }

    for (e = (6-d); e >1 ; e--)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}
Console.WriteLine();