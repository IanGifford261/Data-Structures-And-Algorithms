using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;
using StacksanQueues.Classes;

namespace FIFOAnimalShelter.Classes
{
   public class Animal
    {
        public Animal Val { get; set; }
        public Animal Next { get; set; }

        public Animal (Animal woofMeow)
        {
            Val = woofMeow;
            Next = null;
        }        
    }
}
