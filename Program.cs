using System;
using System.Collections.Generic;

namespace Jurassic
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to JURASSIC PARK!");
      Console.WriteLine("-------------------------");
      var tracker = new DinosaursTracker();

      var isRunning = true;
      while (isRunning)
      {
        foreach (var dino in tracker.Dinosaurs)
        {
          Console.WriteLine($"{dino.DinoName.ToUpper()} - DIET: {dino.DinoDietType} - WEIGHT: {dino.Weight} - Enclosure #: {dino.EnclosureNumber} - Added On: {dino.DateAcquired} "); //their weight is {dino.Weight} they came in on {dino.DateAcquired} they currently in {dino.EnclosureNumber}");
        }
        Console.WriteLine("Want would you like to do?");
        Console.WriteLine("(Add) (Remove) (Move) (Diet) (Heaviest) (Quit)");
        var input = Console.ReadLine().ToLower();
        if (input == "add")
        {
          Console.WriteLine("What type of Dinosaur was it?");
          var name = Console.ReadLine();

          Console.WriteLine("Are they a Carnivore or Herbivore?");
          var dietType = Console.ReadLine();

          Console.WriteLine("How much do they weigh?");
          var weight = Int32.Parse(Console.ReadLine());
          // covert string to an int

          Console.WriteLine("What enclosure number are they in?");
          var enclosureNumber = Int32.Parse(Console.ReadLine());


          tracker.AddADinosaur(name, dietType, weight, enclosureNumber);
        }
        else if (input == "remove")
        {
          Console.WriteLine("What dinosaur would you like to remove?");
          var creature = Console.ReadLine();
          tracker.RemoveDinosaur(creature);
        }
        else if (input == "move")
        {
          Console.WriteLine("Who do you want to move");
          var dino = Console.ReadLine();
          Console.WriteLine("Which pen?");
          var newPen = Console.ReadLine();
          tracker.MoveDinosaur(dino, newPen);
        }
        else if (input == "diet")
        {
          tracker.ViewDietType();
        }
        else if (input == "heaviest")
        {
          tracker.GetThreeHeaviest();
        }

        else if (input == "quit")
        {
          isRunning = false;
        }
      }
    }
  }
}
