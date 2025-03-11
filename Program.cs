using System;
using System.Collections.Generic;

namespace Hello
{
    class Program
    {
        // This is the entry point of the program
        static void Main(string[] args)
        {
            // Printing Hello World
            /*
                First Program
            */
            Console.WriteLine("Hello World");

            // Working with variables
            int fav = 54;  // Declaring an integer variable
            Console.WriteLine("My Favourite Number is: " + fav);

            // Reading input from user and displaying it
            string inp = Console.ReadLine();  // Reads input from user
            Console.WriteLine("You Entered: " + inp);

            // Working with different types of variables
            double pi = 3.14159; // Declaring a double variable
            bool isLearning = true; // Declaring a boolean variable
            Console.WriteLine("Pi is approximately: " + pi);
            Console.WriteLine("Is Learning C# fun? " + isLearning);

            // Collections: Arrays
            int[] numbers = { 1, 2, 3, 4, 5 };  // Array to store integers
            Console.WriteLine("Array of Numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Collections: List
            List<string> colors = new List<string> { "Red", "Green", "Blue" };  // List to store strings
            Console.WriteLine("Colors in the List:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Working with Classes and Objects
            // Creating an object of the 'Person' class
            Person person = new Person();
            person.Name = "John";
            person.Age = 25;
            person.Speak();  // Calling the Speak method of the 'Person' class

            // More examples of classes and objects
            Car myCar = new Car("Toyota", "Corolla", 2020);
            myCar.DisplayCarInfo();  // Displaying car information

            // Object with parameterized constructor
            Person anotherPerson = new Person("Alice", 30);
            anotherPerson.Speak();

            // Waiting for user input before closing
            Console.ReadLine();
        }
    }

    // Class definition for Person
    class Person
    {
        public string Name { get; set; }  // Property for Name
        public int Age { get; set; }  // Property for Age

        // Default constructor
        public Person()
        {
        }

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to make the person speak
        public void Speak()
        {
            Console.WriteLine(Name + " says: Hello, I am " + Age + " years old.");
        }
    }

    // Class definition for Car
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor for Car class
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Method to display car information
        public void DisplayCarInfo()
        {
            Console.WriteLine("Car Information: " + Year + " " + Make + " " + Model);
        }
    }
}
