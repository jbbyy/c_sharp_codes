/*If number contains 3
Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.
Expected input and output
IfNumberContains3(7201432) → true
IfNumberContains3(87501) → false
  */

 bool IfNumberContains(int x)
{
    int c;
    while(x > 0)
    {
        if (x % 10 == 3)
        {
            return true;
        }
        else
        {
            x = x / 10;
            
        }
        
    }
    return false;
    
}

Console.WriteLine(IfNumberContains(22224));
Console.WriteLine(IfNumberContains(22324));