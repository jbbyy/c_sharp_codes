/* Write a method that draws Christmas tree shape like below.
Expected input and output
DrawChristmasTree() →
   *
  ***
 *****
*******
   *
  ***
 *****
*******
   *
  ***
 *****
********/

string[] xmas = new string[] {" ", " ", " ", "*", " ", " ", " "};
foreach(string x in xmas)
{
    Console.Write(x);
}
Console.WriteLine();

for(int a = 1; a<=3; a++)
{
    foreach (string x in xmas)
    {
        Console.Write(x);
    }
    Console.WriteLine();

    while (xmas[0] == " ")
{
        for (int j = 0; j < (xmas.Length+1) /2 ; j++)
        {
            if (xmas[j] == "*") 
            {  xmas[j - 1] = "*";
                xmas[(xmas.Length)-j ] = "*";
                foreach (string x in xmas)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            break;
            }

        
         } 
}
xmas = new string[] { " ", " ", " ", "*", " ", " ", " " };
}