using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rasim", "Kochaliev", 18, Person.Genders.Male);
            Console.WriteLine(p.ToString());

            Manager m = new Manager("Rasim", "Kochaliev", 18, Manager.Genders.Male, "925-409-5443", "223b");
            Console.WriteLine(m);
        }
        class Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;
            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }
            public override string ToString()
            {
                return firstName + " " + lastName + " (" + gender + "), age " + age;
            }
            public enum Genders : int { Male, Female };
        }
        class Manager : Person
        {
            string phoneNumber;
            string officeLocation;
            public Manager(string _firstName, string _lastName, int _age, Genders _gender, string _phoneNumber, string _officeLocation)
                : base(_firstName, _lastName, _age, _gender)
            {
                phoneNumber = _phoneNumber;
                officeLocation = _officeLocation;
            }
            public override string ToString()
            {
                return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
            }
        }
    }
}