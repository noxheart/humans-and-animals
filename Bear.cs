using System;

class Bear : Animal
{
    public Bear(string bearName, int bearHunger, string bearDiet)
    {
        this.Name = bearName;
        this.HungerLvl = bearHunger;
        this.Diet = bearDiet;
    }
    
}