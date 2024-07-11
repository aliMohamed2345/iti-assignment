// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorldApp
{
    class Test
    {
        class Person {
    string name;
    int id; 
    int age;
    int phone;

    public Person(int id, string name, int phone, int age) {
        age = age; 
        phone = phone; 
        name = name; 
        id = id; 
}
       public override string ToString() {
        return $"Person[ID: {id}, Name: {name}, Phone: {phone}, Age: {age}]";
    }
        }
        static void Main(string[] args)
        {
            #region question1 
            const int maxMultipliedNum = 12;
            Console.WriteLine("please input a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxMultipliedNum; i++)
            {
                Console.WriteLine($"{i + 1} * {num} ={num * (i + 1)}");
            }
            #endregion

            #region question2
            int age;
            do
            {
                Console.Write("Please enter your age (must be a positive number): ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("The age cannot be negative. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    age = -1; // Set age to -1 to continue the loop if input is not a number
                }
            } while (age < 0);
            Console.WriteLine($"You entered a valid age: {age}");
            #endregion
            #region question3

            #endregion
        Person person1 = new Person(234, "Ali Mansor", 234234123, 20);
        Console.WriteLine(person1); 
        }
    }
    }
    
