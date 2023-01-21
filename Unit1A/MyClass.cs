//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{
	public Phone Iphone;
	public Phone Android;
	public Phone Google;
	
	public void Main()
	{
		Iphone = new Phone();
		Android = new Phone();
		Google = new Phone():
		
		Iphone.User_Ability = 2;
		Iphone.Affordability = 1;
		Iphone.Battery = 2;
        Iphone.Average_person = "Very Cool Person";
		
		Android.User_Ability = 8;
		Android.Affordability = 5;
		Android.Battery = 7;
        Android.Average_person = "Very Cool Person";

		Google.User_Ability = 5;
		Google.Affordability = 8;
		Google.Battery = 7;
        Google.Average_person = "Very Cool Person";
		
        Console.WriteLine("Iphone's stats:")
		Console.WriteLine(Iphone.User_Ability);
		Console.WriteLine(Iphone.Affordability);
		Console.WriteLine(Iphone.Battery);
        Console.WriteLine(Iphone.Average_person);
		
        Console.WriteLine("Android's stats:")
		Console.WriteLine(Android.User_Ability);
		Console.WriteLine(Android.Affordability);
		Console.WriteLine(Android.Battery);
        Console.WriteLine(Android.Average_person);

		Console.WriteLine("Google's stats:")
        Console.WriteLine(Google.User_Ability);
		Console.WriteLine(Google.Affordability);
		Console.WriteLine(Google.Battery);
        Console.WriteLine(Google.Average_person);

        Console.WriteLine("Everyone is still a pretty cool person at the end of the day.")
	}
}

public class Phone {
	public int User_Ability;
	public int Affordability;
	public int Battery;
    public string Average_person;
}
