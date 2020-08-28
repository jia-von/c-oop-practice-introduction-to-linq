using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = SeedIntList(); //Integer List
            List<string> stringList = SeedStringList(); // String List
            List<List<int>> nestedList = SeedNestedList(); // Nested String List
            List<Person> personList = SeedPersonList(); // Person Object List


            // Operating on intList:

            
            Console.WriteLine($"The sum of the numbers that are greater than or equal to 25: {intList.Where(x => x <= 25).Sum()}."); // Output: 120
            Console.WriteLine($"The lowest number that is divisible by both 2 and 3: {intList.Where(x => x % 3 == 0 && x % 2 == 0).Min()}."); // Output: 12
            Console.WriteLine($"The average of the numbers that are single digits: {intList.Where(x => x<10).Average()}."); //Output: 3.5714285714285716
            Console.WriteLine($"The number of distinct numbers starting with 2: {intList.Distinct().Where(x => x.ToString().StartsWith("2")).Count()}"); // Output: 3

            // Operating on stringList:
            Console.WriteLine($"The number of distinct strings (trimmed and case insensitive): {stringList.ConvertAll(x => x.ToLower().Trim()).Distinct().Count()}."); //Output: 4
            Console.WriteLine($"The longest string (trimmed): {stringList.ConvertAll(x => x.ToLower().Trim().Length).Max()}."); // Output: 10
            Console.WriteLine($"The second string when ordered in reverse alphabetical order: {stringList.ConvertAll(x => x.ToLower().Trim()).OrderByDescending(y => y).ElementAt(2)}.");// Answer is yes

            // Operating on nestedList: 
            Console.WriteLine($"The overall largest number across all lists: {nestedList.Select(x => x.Max()).Max()}.");// Output: 100
            Console.WriteLine($"The number of nested lists: {nestedList.Count}.");// Output: 5
            Console.WriteLine($"The number of items in the shortest nested list: {nestedList.Select(x => x.Count()).Min()}."); //Output 1
            Console.WriteLine($"The average of items in the longest nested list: {nestedList.Select(x => x.Count()).Max()}."); //Output 10 of the largest list TODO 30 mins --> Help
            Console.WriteLine($"The number of distinct even items across all lists: {nestedList.Sum(x => x.Distinct().Where(y => y%2 == 0).Count())}."); // Output 13
            Console.WriteLine($"The average of distinct odd items divisible by either 3 or 5 across all lists: {nestedList.Select(x => x.Distinct().Where(y => y%3 ==0 || y%5 == 0).Count()).Average()}."); // Output 2.6

            // Operating on personList: 
            Console.WriteLine($"The number of females in the list: {personList.Where(x => x.Gender.Equals(Person.GenderValue.Female)).Count()}."); //Output: 3
            Console.WriteLine($"The average number of characters in first names: {nestedList}.");
            Console.WriteLine($"The full name of the youngest person: {nestedList}.");
            Console.WriteLine($"The first name of the person with the longest last name: {nestedList}.");
            Console.WriteLine($"The gender of the oldest person: {nestedList}.");



        }

        static List<Person> SeedPersonList()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Sue",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1983, 6, 18),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Tommy",
                    LastName = "Lee",
                    DateOfBirth = new DateTime(1962, 10, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 2, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Barney",
                    LastName = "The Dinosaur",
                    DateOfBirth = new DateTime(1992, 4, 06),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Jane",
                    LastName = "Barber",
                    DateOfBirth = new DateTime(1997, 1, 1),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Avery",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 7, 8),
                    Gender = Person.GenderValue.NotStated
                },
                new Person()
                {
                    FirstName = "Emmett",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 6, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Hermione",
                    LastName = "Granger",
                    DateOfBirth = new DateTime(2001, 11, 16),
                    Gender = Person.GenderValue.Female
                }
            };
        }

        static List<List<int>> SeedNestedList()
        {
            return new List<List<int>>()
            {
                new List<int>() { 42, 12, 3, 7 },
                new List<int>() { 12 },
                new List<int>() { 37, 12, 8, 12, 41, 63, 17, 2, 6, 3 },
                new List<int>() { 90, 100, 12, 7, 17 },
                new List<int>() { 4 * 2, 13 / 3, 90 / 12, 60 % 17, 3 * 3 * 2 }
            };
        }

        static List<string> SeedStringList()
        {
            return new List<string>() { "Yes", "no", "yes", "Yes ", "no", "maybe", "NO", " no", " maYbe ", "definitely" };
        }

        static List<int> SeedIntList()
        {
            return new List<int>() { 3, 10, 2, 3, 12, 7, 12, 12, 24, 42, 101, 3, 25, 42, 60, 72, 5, 2, 100 };
        }
    }
}
