using System;
					
public class Program
{
	public gamemodes charactermodes;
	
	public void Main()
	{
		charactermodes = new gamemodes();
		charactermodes.current_mode = gamemodes.modes.Crucible;
		charactermodes.whichmode();
        //characterbest(current_mode);
	}
	
public class gamemodes {
	public enum modes {
		Gambit,
		Crucible,
		Iron_Banner,
		Vanguard,
		Battlegrounds
	}
	
	public modes current_mode = modes.Gambit;
	
	public void whichmode(){
		switch (current_mode){
			case modes.Gambit:
				Console.WriteLine("Gambit");
				break;
			case modes.Crucible:
				Console.WriteLine("Crucible");
				break;
			case modes.Iron_Banner:
				Console.WriteLine("Iron Banner");
				break;
			case modes.Vanguard:
				Console.WriteLine("Vanguard");
				break;
			case modes.Battlegrounds:
				Console.WriteLine("Battlegrounds");
				break;					
				
		}
	}

    //public void characterbest(current_mode) {
    //if (current_mode = Gambit) {
    //    Console.WriteLine("Warlocks are the best character for Gambit");
    //}
    //else if (current_mode = Crucible) {
    //    Console.WriteLine("Hunters are the best character for Crucible");
    //}
    //else if (current_mode = Iron_Banner) {
    //    Console.WriteLine("Hunters are the best character for Iron Banner");
    //}
    //else if (current_mode = Vanguard) {
    //    Console.WriteLine("Titans are the best character for Vanguard");
    //}
    //else{
    //    Console.WriteLine("Titans are the best character for Battlegrounds");
    //}
//}
}

}