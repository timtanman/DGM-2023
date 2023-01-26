using System;
public class Destiny
{
	public Character Warlock;
	public Character Titan;
	public Character Hunter;
	
	public void Main()
	{
		Console.WriteLine("Which Destiny 2 character class is best?");
		which_class(5, 10, 2);
		
		Warlock = new Character();
		Titan = new Character();
		Hunter = new Character();
		
		Warlock.defense = 10;
		Warlock.offense = 2;
		Warlock.abilities = 4;
		
		Titan.defense = 8;
		Titan.offense = 10;
		Titan.abilities = 2;
		
		Hunter.defense = 3;
		Hunter.offense = 7;
		Hunter.abilities = 10;
		
		defense_stats(Warlock.defense, Titan.defense, Hunter.defense);
		offense_stats(Warlock.offense, Titan.offense, Hunter.offense);
		abilities_stats(Warlock.abilities, Titan.abilities, Hunter.abilities);
		
		
	}
	
	public void which_class(int warlock, int titan, int hunter) {
		var best_class = titan + 10;
		var warlock_class = warlock + 10;
		var hunter_class = hunter + 10;
		Console.WriteLine("These are the basic stats");
		Console.WriteLine(warlock_class + " is the power level of the Warlock, pretty high, but not the best");
		Console.WriteLine(hunter_class + " is the power level of the Hunter, not too great, but still ok");
		Console.WriteLine(best_class + " is the power level of titan, so it is the best");
	}
	public void defense_stats(int warlock, int titan, int hunter) {
		if ((warlock > titan) && (warlock > hunter)) {
			Console.WriteLine("Warlock's are definitely better at defense");
		}
		else if ((titan > warlock) && (titan > hunter)){
			Console.WriteLine("Titan's have the best defense in the game");
		}
		else {
			Console.WriteLine("Hunter's have the best defense in the game");
		}
	}
	public void offense_stats(int warlock, int titan, int hunter) {
		if ((titan > warlock) && (titan > hunter)){
			Console.WriteLine("Titans have the best offense in the game");
		}
		else if ((hunter > warlock) && (hunter > titan)){
			Console.WriteLine("Hunter's have the best offense in the game");
		}
		else {
			Console.WriteLine("Warlock's have the best offense in the game");
		}
	}
	public void abilities_stats(int warlock, int titan, int hunter) {
		if ((hunter > titan) && (hunter > warlock)){
			Console.WriteLine("Hunter's have the best abilities in the game");
		}
		else if ((titan > warlock) && (titan > hunter)){
			Console.WriteLine("Hunter's have the best abilities in the game");
		}
		else {
			Console.WriteLine("Warlock's have the best abilities in the game");
		}
	}

public class Character{
	public int defense;
	public int offense;
	public int abilities;
}
}