using System;

class Coyote : Animal
{
    public Coyote(string coyoteName, int coyoteHunger, string coyoteDiet)
    {
        this.Name = coyoteName;
        this.HungerLvl = coyoteHunger;
        this.Diet = coyoteDiet;
    }
}