using System;

class Animal
{
    private string name;
    private int hungerLvl = 0;
    private string diet;
    private string type;
    private int feedTime;
    
    

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

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public int FeedTime 
    {
        get { return feedTime; }
        set { feedTime = value; }
    }

    

    
    
}