using System;

namespace Jurassic
{
  public class Dinosaur
  {
    // Name of Dinosaur
    public string DinoName { get; set; }

    // DietType - Carnivore Herbivore
    public string DinoDietType { get; set; }

    // DateAcquired
    public DateTime DateAcquired { get; set; }

    // Weight
    public int Weight { get; set; }

    // EnclosureNumber
    public int EnclosureNumber { get; set; }
  }
}