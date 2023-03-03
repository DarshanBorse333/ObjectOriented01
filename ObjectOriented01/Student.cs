using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented01
{
    namespace demo
    {

    }
    internal class Student
    {
        public int Id { get; set; }   //Property,, if there is get and set

        private int id; //  Feilds,, if there is no get and set 
        public static void Demo()  // Function,,
        {
            Console.WriteLine("");
            
        } 

        public static void CalculateArea(string shape) // accepting string
        {

        }

        // Behaving in different ways depending upon input recieved use of same thing for diff purposes
        // we can see the same name function is used but for different purposes known as polimorphism
        public static void CalculateArea()
        {

        }

    }

    internal class user:Student // Student class can be reuse by establishing parent-child reltionship known as inheritance
    {
        public static void Demo()
        {
            Console.WriteLine("");
        }
    }

    internal class Employee
    {

    }
}
