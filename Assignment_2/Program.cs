using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int n = 1; n <= 10; n++)
                { 
                //Creating an object of Student class in Program.cs
                    Console.WriteLine($"For Student[{n}]");
                    Student st = new Student();
                    st.getDetails();
                    st.findAge();
                    st.validateEmail();
                    st.display();

                    Console.WriteLine("**********************************************************");
                }
            
            Console.ReadLine();
        }
    }
}
