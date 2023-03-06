/*Write a method that draws hourglass shape like below.
Expected input and output
DrawHourglass() →
***********
 *********
  *******
   *****
    ***
     *
    ***
   *****
  *******
 *********
***********
 */
/*Console.WriteLine("Enter number of rows ( odd number only)");

int x = Convert.ToInt16(Console.ReadLine());

    string[] y = new string[x];
    Array.Fill(y, "*");*/

string[] y = new string[] { "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" };



foreach ( string a in y)
{
    Console.Write(a);
}
Console.WriteLine();
   for (int i = 0; i <= 10; i++)
    {
        if (y[i] == "*")
        {
            y[i] = " ";
        }
        else if (y[i] == " ")
        {
            y[i] = "*";
        }

    //int j = -1 - i; ( c sharp doesnt allow for negative index , cant use [^0] = -1??
        if (y[10- i] == "*")
         {
             y[10 - i] = " ";
        }
        else if (y[10 - i] == " ")
        {
             y[10 - i] = "*";
         } 

        foreach (string a in y)
         {
            Console.Write(a);
        
      
         }
            Console.WriteLine();
    }
   
   