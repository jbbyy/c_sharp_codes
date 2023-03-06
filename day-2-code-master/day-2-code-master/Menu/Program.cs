class program
{
public static void Main(string[]args)
{
double choice, num1, num2;
System.Console.WriteLine("Welcome to calculator Menu");
System.Console.WriteLine("1. Addition \n"+ "2. Subtraction \n" + "3. Multiplication\n" + "4. Division \n" +"Enter your choice");


choice = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter first number");
num1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Please enter second number");
num2 = Convert.ToDouble(System.Console.ReadLine());

switch(choice)
{
case 1:
{
System.Console.WriteLine("Result is " + (num1 + num2) );
break;
}
case 2:
{
System.Console.WriteLine("Result is " + (num1 - num2));
break;
}

case 3:
{
System.Console.WriteLine("Result is " + (num1*num2));
break;
}
case 4:
{
System.Console.WriteLine("Result is " + (num1/num2));
break;
}


}
}
}

