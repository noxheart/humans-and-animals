using System;

class Seal : Animal
{
    
    public Seal(string sealName, int sealHunger, string sealDiet, int sealFeed)
    {
        this.Name = sealName;
        this.HungerLvl = sealHunger;
        this.Diet = sealDiet;
        this.Type = "Seal";
        this.FeedTime= sealFeed;
        /*if (this.HungerLvl == 13)
        {
            this.FeedTime = true;
        }*/
    }

    private int CheckAnimal(int meatLeft)
    {
        this.HungerLvl++;

        if (this.HungerLvl >= this.FeedTime )
        {
            if (meatLeft > 0)
            {
                Console.WriteLine("{0}en {1} fick äta {2}. Det finns {3} {4}bitar kvar", this.Type, this.Name, this.Diet, meatLeft, this.Diet);
                this.HungerLvl = 0;
                meatLeft--;
            }
            else if (meatLeft == 0)
            {
                Console.WriteLine("{0}en {1} behövde få mat, men det finns inget {2} kvar!", this.Type, this.Name, this.Diet);
            }
        }
        else 
        {
            Console.WriteLine("{0}en {1} behövde inte äta idag", this.Type, this.Name);
        }
        return meatLeft;
    }
    
}