using System;
					
public class Program
{
	public void Main()
	{
		string[] starcraftnames = {"Marine", "Battlecruiser", "SCV", "Seige Tank", "Ghost", "Firebat", "Hyperion", "Medic", "Medivac", "Viking"};
		starcraftnames[1] = "Superior Battlecruiser";
		starcraftnames[4] = "Spectre";
		
		for (var i = 0; i < starcraftnames.Length; i++) {
			starcraftnames[i] = "Superior " + starcraftnames[i];
		}
		foreach(var terran in starcraftnames) {
			Console.WriteLine(terran);
		}
	}
}