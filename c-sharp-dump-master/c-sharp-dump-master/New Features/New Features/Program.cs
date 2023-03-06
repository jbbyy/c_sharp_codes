using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

public class Demo
{
   public void sum(int a, int b, out int c) 
        // if you dont specify anything before parameter, it will be input parameter. 
        // if theres an out, it is an output parameter
    {
        c = a + b;
    }

    
}


internal class program
{
    static void Main(string[] args)
    {
       
        Demo d = new Demo();
        int result;
        d.sum(10, 20, out result); // able to take C out of Sum method. 
        Console.WriteLine(result);
        // use this when we are unable to return value.
        // Can have multiple out parameters whereas only 1 return value
    }
}
