//Write a program to accept a letter from user and display if its is vowel or not

class program
{
public static void Main(string[]args){
string letter;
System.Console.WriteLine("Please enter a letter");
letter = (System.Console.ReadLine());
switch(letter)
{
case "a":
{
System.Console.WriteLine("a is a vowel");
break;
}

case "e":
{
System.Console.WriteLine("e is a vowel");
break;
}

case "i":
{
System.Console.WriteLine("i is a vowel");
break;
}
case "o":
{
System.Console.WriteLine("o is a vowel");
break;
}
case "u":
{
System.Console.WriteLine("u is a vowel");
break;
}
default:
{
System.Console.WriteLine(letter+ " is not a vowel");
break;
}
}
}
}

