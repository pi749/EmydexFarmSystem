using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
  public class EmydexFarmSystem
  {

    private List<Animal> lstAnimals = new List<Animal>();

    //TEST 1
    public void Enter(object animal)
    {
      //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
      //Hold all the animals so it is available for future activities

      Animal objAnimal = animal as Animal;

      if (objAnimal != null)
      {

        lstAnimals.Add(objAnimal);
        objAnimal.DisplayAnimal();
        Console.WriteLine(" has entered the Emydex farm");
      }

    }

    //TEST 2
    public void MakeNoise()
    {
      //Test 2 : Modify this method to make the animals talk

      if (lstAnimals.Count > 0)
      {
        foreach (Animal a in lstAnimals)
        {
          (a as Animal).Talk();
        }
      }
      else
        Console.WriteLine("There are no animals in the farm");
    }

    //TEST 3
    public void MilkAnimals()
    {
      if (lstAnimals.Count > 0)
        foreach (Animal a in lstAnimals)
        {

          if (a is IMilkableAnimal)
          {
            (a as Animal).DisplayAnimal();
            Console.WriteLine(" was milked");
          }
          //else
          //  Console.WriteLine("Cannot identify the farm animals which can be milked");
        }
    }

    //TEST 4
    public void ReleaseAllAnimals()
    {

      int intAnimalOutCount = 0;
      foreach(Animal a in lstAnimals)
      {
        (a as Animal).DisplayAnimal();
        Console.WriteLine( " has left the farm");
        intAnimalOutCount++;
      }

      if (intAnimalOutCount != 0 && lstAnimals.Count == intAnimalOutCount)
      {
        lstAnimals.Clear();
        Console.WriteLine("Emydex Farm is now empty");
      }
      else
        Console.WriteLine("There are still animals in the farm, farm is not free");
    }
  }
}