using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person3
    {
        //private string fName;// these cannot be accessed directly from Program.cs
        
        private int age;
        public int Age //property
        { 
            get { return age;}
            set { 
                age = value;
            }
        
        
        }
    }
}
