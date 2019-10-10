using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            public string animalType;
            
            List<Animal> animalList = new List<Animal>();
            Säl mySeals = new Säl("Sälis", 0, "kött");
            animalList.Add(mySeals);
            Bear myBears = new Bear("Björne", 0, "kött & blad");
            animalList.Add(myBears);
            Coyote myCoyote = new Coyote("Cajsa", 0, "kött");
            animalList.Add(myCoyote);
            Elephant myElephant = new Elephant("Elias", 0, "blad");
            animalList.Add(myElephant);
            Giraffe myGiraffe = new Giraffe("Gifflan", 0, "blad");
            animalList.Add(myGiraffe);
            Giraffe myGiraffe2 = new Giraffe("Henrik", 0, "blad");
            animalList.Add(myGiraffe2);

            foreach (var item in animalList)
            {
                Console.WriteLine("Namn: {0}.| Diet: {1}.| Hungrighet: {2}", item.Name, item.Diet, item.HungerLvl);
            }




        }
    }
}
