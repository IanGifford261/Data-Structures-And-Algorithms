using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public Shelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }
    }
}
