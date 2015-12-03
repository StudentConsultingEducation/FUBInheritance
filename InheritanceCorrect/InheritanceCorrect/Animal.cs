using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCorrect
{
    //All property and variables are examples. Any are fine.
    #region Assignment1
    public class Animal
    {
        #region Assignment2
        private string name;
        private int numberOfLegs;
        private bool isMamal;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NumberOfLegs 
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }
        public bool IsMamal
        {
            get { return isMamal; }
            set { isMamal = value; }
        }
        #endregion
    }
    #endregion
    #region Assignment3&4
    public class Horse : Animal
    {
        private string breed;
        private string colour;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

    }
    public class Dog : Animal
    {
        private string size;
        private double weight;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
    public class Hedgehog : Animal
    {
        private int numberOfSpikes;
        private bool isHibernating;

        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }

        public bool IsHibernating
        {
            get { return isHibernating; }
            set { isHibernating = value; }
        }
    }
    public class Worm : Animal
    {
        private double length;
        private string typeOfWorm;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public string TypeOfWorm
        {
            get { return TypeOfWorm; }
            set { typeOfWorm = value; }
        }
    }
    public class Bird : Animal
    {
        private bool birdOfPassage;
        private string family;

        public bool BirdOfPassage
        {
            get { return birdOfPassage; }
            set { birdOfPassage = value; }
        }

        public string Family
        {
            get { return family; }
            set { family = value; }
        }
    }
    #endregion
    //For assignment 5-10 see Program.cs
    #region Assignment11&12
    public class Pelican : Bird
    {
        private double beakSize;
        private double wingSpan;

        public double BeakSize
        {
            get { return beakSize; }
            set { beakSize = value; }
        }
        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value;}
        }
    }
    public class Swan : Bird
    {
        private bool propertyOfHMTheQueen;
        private double neckLength;
        public bool PropertyOfHMTheQueen
        {
            get { return propertyOfHMTheQueen; }
            set { propertyOfHMTheQueen = value; }
        }
        public double NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }
    }

    public class Flamingo : Bird
    {
        private bool standing;
        private string colour;

        public bool Standing
        {
            get { return standing; }
            set { standing = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
    #endregion
    //For assignment 13-16 see Program.cs
}
