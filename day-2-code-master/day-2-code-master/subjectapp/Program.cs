
class program
{
public static void Main(string[]args)
{

//Write a program to take 5 subject marks and calculate total sum and average

double math, science, english, arts, history, average, sum;
System.Console.WriteLine("Please enter marks for Math");
math = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter marks for Science");
science = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter marks for English");
english = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter marks for Arts");
arts = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter marks for History");
history = Convert.ToDouble(System.Console.ReadLine());
sum = math + science + english + arts + history;
average = sum/5;
System.Console.WriteLine("Total marks for 5 subjects is " + sum + " and your average mark is " + average);


}
}