using System;
					
public class Program
{
	public void Main()
	{
		string[] starcraftnames = {"Marine", "Battlecruiser", "SCV", "Seige Tank", "Ghost", "Firebat", "Hyperion", "Medic", "Medivac", "Viking"};
		starcraftnames[1] = "Superior Battlecruiser";
		starcraftnames[4] = "Spectre";
		var i = 0;
		while (i <starcraftnames.Length) {
			starcraftnames[i] = "Superior " + starcraftnames[i];
			i++;
		}
		foreach(var terran in starcraftnames) {
			Console.WriteLine(terran);
		}
	}
}