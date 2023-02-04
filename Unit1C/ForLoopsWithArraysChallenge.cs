using System;


    public class Program
    {
        public void Main(string[] args)
        {
            string[] vermintide = {"Markus Kruber", "Kerillian", "Bardin Goreksson", "Sienna Fuegonasus"};
            string herosassigned = "";
            for (int i = 0; i < vermintide.Length; i++)
            {
                herosassigned += vermintide[i] + " ";
            }
            Console.WriteLine(herosassigned);
        }
    }
