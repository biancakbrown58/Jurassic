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

    public void MoveDinosaur(string who, string pen)
    {
      var dino = Dinosaurs.First(dinosaur => dinosaur.DinoName == who);
      dino.EnclosureNumber = int.Parse(pen);
    }

    public void ViewDietType()
    {
      var vegDino = Dinosaurs.Count(dinosaur => dinosaur.DinoDietType.Contains("herbivore"));
      Console.WriteLine($"There are {vegDino} Herbivores");

      var carnDino = Dinosaurs.Count(dinosaur => dinosaur.DinoDietType.Contains("carnivore"));
      Console.WriteLine($"There are {carnDino} carnivores");


    }

    public void GetThreeHeaviest()
    {
      var heaviest = Dinosaurs.OrderByDescending(dinosaur => dinosaur.Weight).Take(3);
      foreach (var dino in heaviest)
      {
        Console.WriteLine($"{dino.DinoName} with a weight of {dino.Weight}");
      }
    }

  }
}



