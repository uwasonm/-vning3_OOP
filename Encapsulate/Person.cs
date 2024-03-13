using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    internal class Person
    {

        private int age;
        private string fName;// these cannot be accessed directly from Program.cs
                             // unless if one uses a property
        private string lName;
        private int height;
        private int weight;

       // public Person( int age, string fName, string lName, int height, int weight)
        //{
        //}

        public int Age //property
        {
         get { return age; }
         set 
         {age = value;}
        }
           
    
        public string FName //  fName property with exception handling
        {
            get { return fName; }
            set {
                if (fName is null)
                {
                    throw new ArgumentNullException();
                }
                else if (fName.Length <2 || fName.Length > 10)
                {
                    throw new FormatException();
                }
                
                else fName = value; }

            }

        public string LName
        {
            get { return lName; }
            set
            
            { lName = value; }
            //}
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }

   
}