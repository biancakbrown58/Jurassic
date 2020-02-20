using System;
using System.Collections.Generic;
using System.Linq;

namespace Jurassic
{
  public class DinosaursTracker
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

    public void AddADinosaur(string name, string dietType, int weight, int enclosureNumber)
    {
      var dinosaur = new Dinosaur
      {
        DinoName = name,
        DinoDietType = dietType,
        DateAcquired = DateTime.Now,
        Weight = weight,
        EnclosureNumber = enclosureNumber
      };
      Dinosaurs.Add(dinosaur);
    }

    public void RemoveDinosaur(string name)
    {
      var thingToRemove = Dinosaurs.Where(dinosaur => dinosaur.DinoName == name).ToList();
      if (thingToRemove.Count() > 1)
      {
        Console.WriteLine($"We found multiple {name}'s, which # do you want to remove?");
        for (int i = 0; i < thingToRemove.Count; i++)
        {
          var creature = thingToRemove[i];
          Console.WriteLine($"{i + 1}: {creature.DinoName} with {creature.DinoDietType} in enclosure {creature.EnclosureNumber} added on {creature.DateAcquired}");
        }
        var index = int.Parse(Console.ReadLine());
        Dinosaurs.Remove(thingToRemove[index - 1]);
      }
      else
      {
        Dinosaurs.Remove(thingToRemove.First());
      }
    }

    // public void MoveDinosaur(string name)
    // // DOESNT WORK YET! UGH
    // {
    //   var thingToMove = Dinosaurs.IndexOf(Dinosaurs => Dinosaurs.DinoName.Contains(name)));
    //   //if (thingToMove.Count() > 1)
    //   //{
    //   //Console.WriteLine($"There are multiple {name}'s, who do you want to move?");
    //   // for (int i = 0; i < thingToMove.Count; i++)
    //   // {
    //   //   var home = thingToMove[i];
    //   //   Console.WriteLine($"{i + 1}: {home.DinoName} in {home.EnclosureNumber}");
    //   // }
    //   // var index = int.Parse(Console.ReadLine());
    //   Console.WriteLine("Where do you want to move them? enter a number");
    //   var newEnclosure = Console.ReadLine();
    //   Dinosaurs[thingToMove].EnclosureNumber = newEnclosure;
    //   //  Dinosaurs.Remove(thingToMove[index - 1]);
    //   // }
  }

  // public void ViewDietType(string dietType)
  // {
  //   // DOESNT WORK!!

  //   //loop through the list of diet types and select the ones for separate 
  //   // category and get the total 
  //   Console.WriteLine("Enter 'carnivore' or 'herbivore' to see the total # of dinosaurs for that diet type");
  //   var userInput = Console.ReadLine();
  //   var viewDietTotal = Dinosaurs.Count(dinosaur => dinosaur.DinoDietType.Contains(userInput));

  //   if (userInput == "carnivore")
  //   {
  //     Console.WriteLine($"The total carnivores are {viewDietTotal}");
  //   }

  // }
}

