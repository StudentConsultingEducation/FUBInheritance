using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCorrect
{
    class Program
    {
        //For assignment 1 see Animal.cs
        static void Main(string[] args)
        {
            #region Assignment5
            List<Animal> Animals = new List<Animal>();
            #endregion
            #region Assignment6
            Dog Animal1 = new Dog { Name = "Fido", IsMamal = true, NumberOfLegs = 4, Size = "Medium", Weight = 40 };
            Bird Animal2 = new Bird { Name = "Leffe", IsMamal = false, NumberOfLegs = 2, BirdOfPassage = true, Family = "Tit" };
            Horse Animal3 = new Horse { Name = "Golden Star", IsMamal = true, NumberOfLegs = 4, Breed = "Ardener", Colour="Black"};

            Animals.Add(Animal1);
            Animals.Add(Animal2);
            Animals.Add(Animal3);
            #endregion
            #region Assignment7
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.GetType());
            }
            Console.ReadKey();
            #endregion
            #region Assignment8-10
            List<Dog> Dogs = new List<Dog>();
            //Dogs.Add(Animal3); Does not compile, can't convert horses to dogs 
            #endregion
            //For Assignment 11-12 see Animal.cs
            #region Assignment 13-16
            //To store Flamingo, Pelican and Swan a list must store the type Bird
            //To store any of our custom classes a list must store the type Animal
            //If an attribute is for all Birds it will be put in the bird class
            //If an attribute is for all Animals it will be put in the Animal class
            #endregion 
        }
    }
}

