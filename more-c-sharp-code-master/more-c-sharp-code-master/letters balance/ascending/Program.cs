/* Letters balance
Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string. Assume string length is even and letters don't repeat on each side.
Expected input and output
LettersBalance("fgvgvf") → true
LettersBalance("lampsmpser") → false*/

using System.Diagnostics.CodeAnalysis;

bool balance(string x)
{
    int a = x.Length; 
    string b = x.Substring(0, a/2);
    string c = x.Substring((a/2 -1), a/2);

    for(int i = 0; i<a/2; i++)
    {
        if (!(b.Contains(c[i])))
        {
            return false;
        }
    }
return true;

}
Console.WriteLine(balance("fgvgvf"));
Console.WriteLine(balance("lampsmpser"));
