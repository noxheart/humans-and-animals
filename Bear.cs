using System;

class Bear : Animal
{
    public Bear(string bearName, int bearHunger, string bearDiet, int bearFeed)
    {
        this.Name = bearName;
        this.HungerLvl = bearHunger;
        this.Diet = bearDiet;
        this.Type = "Bear";
        this.FeedTime = bearFeed;
    }
    
}