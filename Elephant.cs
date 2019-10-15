using System;

class Elephant : Animal
{
    public Elephant(string elephantName, int elephantHunger, string elephantDiet, int elephantFeed)
    {
        this.Name = elephantName;
        this.HungerLvl = elephantHunger;
        this.Diet = elephantDiet;
        this.Type = "Elephant";
        this.FeedTime = elephantFeed;
    }
}