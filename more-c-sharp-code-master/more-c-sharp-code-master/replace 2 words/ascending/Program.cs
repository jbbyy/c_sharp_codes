/*Given a string in which two words are separated by a char, write a method that replaces these two words.
Expected input and output
ReplaceWords("abc_xyz", '_') → xyz_abc
ReplaceWords("trolling.master", '.') → master.trolling */

string ReplaceWords(string x, char y)
{
    string [] a = x.Split(Convert.ToString(y));
    return (a[1] + Convert.ToString(y) + a[0]);

}

Console.WriteLine(ReplaceWords("abc_xyz", '_'));
Console.WriteLine(ReplaceWords("trolling.master", '.'));