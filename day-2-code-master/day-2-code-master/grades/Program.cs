class program
{
public static void Main(string[]args)
{

//Write a program to take 5 subject marks and calculate total sum and average
/* Using grades program, 
91-100 = A
81-90 = B
71-80 = C
61-70 = D
< 60 = E */



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

if(average >= 91)
{
System.Console.WriteLine("Grade A");
}

else if (average >= 81 && average <91)
{
System.Console.WriteLine("Grade B");
}
else if (average >= 71 && average <81)
{
System.Console.WriteLine("Grade C");
}

else if (average >= 61 && average <71)
{
System.Console.WriteLine("Grade D");

}
else
{
System.Console.WriteLine("Grade D");
}
}
}
