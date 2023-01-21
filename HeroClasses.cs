//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroAWESOME;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroAWESOME = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.coolness = 1;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.coolness = 3;

		heroAWESOME.health = 10;
		heroAWESOME.powerLevel = 10;
		heroAWESOME.coolness = 10;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.coolness);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.coolness);

		Console.WriteLine("Hero AWESOME's health is " + heroAWESOME.health + ". That's the maximum level!?!");
		Console.WriteLine("Hero AWESOME's Power Level is " + heroAWESOME.powerLevel + ".  That's the maximum level!?!");
		Console.WriteLine("Hero AWESOME's Coolness is " + heroAWESOME.coolness + ".  That's the maximum level!?!");
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int coolness;
}