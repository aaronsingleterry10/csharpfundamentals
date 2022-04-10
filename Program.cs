using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            //john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Jack", "John", "Mary" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            var firstName = "Aaron";
            var lastName = "Singleterry";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("{0} {1}", firstName, lastName);
            //Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Mark", "Luke" };
            var formattedNames = string.Join(", ", names);
            //Console.WriteLine(formattedNames);

            var text = @"Hi John, 
                        Look into the following paths:
                        c:\folder1\folder2
                        c:\folder3\folder4";
            //Console.WriteLine(text);

            var method = ShippingMethod.Express;
            Console.WriteLine(method);

            var number = 1;
            Increment(number);
            //Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            //Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
