using System;

class Seal : Animal
{
    public Seal(string sealName, int sealHunger, string sealDiet)
    {
        this.Name = sealName;
        this.HungerLvl = sealHunger;
        this.Diet = sealDiet;
        this.Type = "Seal";
    }
}