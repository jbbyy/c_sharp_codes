/* Draw parallelogram
Write a method that draws parallelogram shape like below.
Expected input and output
DrawParallelogram() →
     ***************
    ***************
   ***************
  ***************
 ***************
 */

string[] star = new string[] { " ", " ", " ", " ", " ", " ", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*" };
foreach(string s in star)
{
    Console.Write(s);
   
}
Console.WriteLine();
string temp;
while (star[0] == " ")
{
    for (int j = 0; j < star.Length - 1; j++)
    {
        temp = star[j];
        star[j] = star[j + 1];
        star[j + 1] = temp;
    }
    foreach (string s in star)
    {
        Console.Write(s);
    }
    Console.WriteLine();

}
