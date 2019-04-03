using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Back { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Back = animal;
        }

        public void Enqueue(Animal woofMeow)
        {
            Animal animal = woofMeow;

            if (Front == null)
            {
                Front = animal;
                Back = animal;
            }
            Back.Next = animal;
        }
    }
}
