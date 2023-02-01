using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Subaru", "Toyota", "Honda", "Explorer", "Ford", "Buick", "Back to the future!",};
		Console.WriteLine(cars.Length);
		Console.WriteLine(cars[0]);
		Console.WriteLine(cars[1]);
		Console.WriteLine(cars[2]);
		foreach(var car in cars){
			Console.WriteLine("I love all of my cars, even the " + car);
		}
	}
}