using System;

class Coyote : Animal
{
    public Coyote(string coyoteName, int coyoteHunger, string coyoteDiet, int coyoteFeed)
    {
        this.Name = coyoteName;
        this.HungerLvl = coyoteHunger;
        this.Diet = coyoteDiet;
        this.Type = "Coyote";
        this.FeedTime = coyoteFeed;
    }
}