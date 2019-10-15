using System;

class Giraffe : Animal
{
    public Giraffe(string giraffeName, int giraffeHunger, string giraffeDiet, int giraffeFeed)
    {
        this.Name = giraffeName;
        this.HungerLvl = giraffeHunger;
        this.Diet = giraffeDiet;
        this.Type = "Giraffe";
        this.FeedTime = giraffeFeed;
    }
}