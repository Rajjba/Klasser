using System;

public class Boll
{
    public Boll(double radie, string färg, int xPosition, int yPosition)
    {
        this.radie = radie;
        this.färg = färg;
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    public double radie{get; set;}
    public string färg;
    public int xPosition;
    public int yPosition;
}
