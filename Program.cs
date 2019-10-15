using System;
using System.Collections.Generic;

namespace humans_and_animals
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            Seal mySeals = new Seal("Sälis", 0, "kött", 13);
            animalList.Add(mySeals);
            Bear myBears = new Bear("Björne", 0, "kött & blad", 3);
            animalList.Add(myBears);
            Coyote myCoyote = new Coyote("Cajsa", 0, "kött", 15);
            animalList.Add(myCoyote);
            Elephant myElephant = new Elephant("Elias", 0, "blad", 10);
            animalList.Add(myElephant);
            Giraffe myGiraffe = new Giraffe("Gifflan", 0, "blad", 7);
            animalList.Add(myGiraffe);
            Giraffe myGiraffe2 = new Giraffe("Henrik", 0, "blad", 7);
            animalList.Add(myGiraffe2);

            /*for (int i =0; i < animalList.Count; i++)
            {
                Console.WriteLine("Animal: {0} |Name: {1} | Diet: {2} | Hungerlevel: {3}",animalList[i].Type, animalList[i].Name, animalList[i].Diet, animalList[i].HungerLvl);
            }*/
            foreach (var animal in animalList)
            {
                Console.WriteLine("Animal: {0} |Name: {1} | Diet: {2} | Hungerlevel: {3}",animal.Type, animal.Name, animal.Diet, animal.HungerLvl);
            }

                // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 50;
            int day = 0;
            

            while (true) 
            {
                day++;
                Console.WriteLine("_______________");
                Console.WriteLine("Det är dag " + day + ":");
                Console.WriteLine();
                
                // LÄGG TILL DIN NYA KOD HÄR
                foreach (var animal in animalList)
                {   
                    animal.HungerLvl++;
                    //Console.WriteLine("Animal: {0} |Name: {1} | Diet: {2} | Hungerlevel: {3}",animal.Type, animal.Name, animal.Diet, animal.HungerLvl);
                    
                    
                    if (animal.HungerLvl >= animal.FeedTime)
                    {
                        if (animal.Diet == "kött" && nrOfMeatLeft > 0)
                        {   animal.HungerLvl = 0;
                            nrOfMeatLeft--;
                            Console.WriteLine("{0}en {1} fick äta {2}. Det finns {3} {4}bitar kvar", animal.Type, animal.Name, animal.Diet, nrOfMeatLeft, animal.Diet);
                            
                        }
                        else if (animal.Diet == "blad" && nrOfVeggiesLeft > 0)
                        {
                            animal.HungerLvl = 0;
                            nrOfVeggiesLeft--;
                            Console.WriteLine("{0}en {1} fick äta {2}. Det finns {3} {4} kvar", animal.Type, animal.Name, animal.Diet, nrOfVeggiesLeft, animal.Diet);
                        }
                        else if (animal.Diet == "kött & blad")
                        {
                            if (nrOfMeatLeft > 0 || nrOfVeggiesLeft > 0)
                            {
                                if (nrOfVeggiesLeft > nrOfMeatLeft)
                                {
                                    animal.HungerLvl = 0;
                                    nrOfVeggiesLeft--;
                                    Console.WriteLine("{0}en {1} fick äta blad. Det finns {3} blad kvar", animal.Type, animal.Name, animal.Diet, nrOfVeggiesLeft);
                                }
                                else if (nrOfMeatLeft > nrOfVeggiesLeft)
                                {   
                                    animal.HungerLvl = 0;
                                    nrOfMeatLeft--;
                                    Console.WriteLine("{0}en {1} fick äta kött. Det finns {3} köttbitar kvar", animal.Type, animal.Name, animal.Diet, nrOfMeatLeft);
                                }
                                else 
                                {
                                    Random oneOrTwo = new Random();
                                    int twoOrOne = oneOrTwo.Next(1,3);
                                    
                                    if (twoOrOne == 1)
                                    {
                                        animal.HungerLvl = 0;
                                        nrOfVeggiesLeft--;
                                        Console.WriteLine("{0}en {1} fick äta blad. Det finns {3} blad kvar", animal.Type, animal.Name, animal.Diet, nrOfVeggiesLeft);
                                    }
                                    else if (twoOrOne == 2)
                                    {
                                        animal.HungerLvl = 0;
                                        nrOfMeatLeft--;
                                        Console.WriteLine("{0}en {1} fick äta kött. Det finns {3} köttbitar kvar", animal.Type, animal.Name, animal.Diet, nrOfMeatLeft);
                                    }
                                }
                            }
                            else 
                            {
                                break;
                            }
                        }
                        else 
                        {
                            Console.WriteLine("{0}en {1} behövde äta idag men det finns ingen mat kvar");
                        }
                    }
                    else if (animal.HungerLvl < animal.FeedTime)
                    {
                        Console.WriteLine("{0}en {1} behöver inte äta idag", animal.Type, animal.Name);
                    }
                }
                
                // Wait for the next day
                Console.ReadKey();
            }




        }
    }
}
