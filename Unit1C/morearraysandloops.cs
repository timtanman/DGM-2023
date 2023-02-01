using System;
					
public class Program
{
	public void Main()
	{
		teams[] team = {new teams(), new teams(), new teams()};
		team[1].teamname = "Blue";
		team[2].teamname = "Green";
		
		for(var i = 0; i < team.Length; i++) {
			team[i].playercount = 1;
			
		}
		foreach(var player in team) {
			Console.WriteLine(player.teamname);
			Console.WriteLine(player.playercount);
		}
		
	}
}

public class teams {
	public string teamname = "Red";
	public int playercount = 3;
}