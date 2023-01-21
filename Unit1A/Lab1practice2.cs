using System;

public class Destiny_Program
{
    public Sparrow alwaysontime;

    public void Main()
    {
        alwaysontime = new Sparrow();
        alwaysontime.speed += 3;
        Console.WriteLine(alwaysontime.SparrowName + " is getting faster by " + alwaysontime.speed + " mph every second!");

    }
}

public class Sparrow {
    public int speed = 1;
    public string SparrowName = "Always On Time";
}
