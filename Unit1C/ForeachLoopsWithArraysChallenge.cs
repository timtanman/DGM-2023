using System;

    public class Program
    {
        public void Main()
        {
            string[] starcraft = {"Zealots", "Collosus", "Sentry", "Stalker", "Tempest", "High Templar", "Immortal"};
            string units = "";
            foreach (string unit in starcraft)
            {
                units = unit + ", " + units;
            }
            Console.WriteLine("The best protoss units in starcraft 2 are " + units);
        }
    }