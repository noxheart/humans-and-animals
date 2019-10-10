using System;

class Animal
{
    private string name;
    private int hungerLvl = 0;
    private string diet;

    

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }
    public int HungerLvl
    {
        get { return hungerLvl; }
        set { hungerLvl = value; }
    } 
    public string Diet
    {
        get { return diet; }
        set { diet = value; }
    }

}