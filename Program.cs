using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace arryas_collections 
{
    public class Program {
        static void Main(string[] args)
        {
            // arrays
            int[] numbers = new int[5];
            int[] numbers2 = { 1, 2, 3 };
            System.Console.WriteLine(numbers);
            System.Console.WriteLine(numbers2);

            //lists
            List<int> numbersList = new List<int>(5);
            List<int> numbersList2 = new List<int>();
            List<int> numbersList3 = new List<int>() {1, 2, 3, 4 };

            numbersList.Add(1);
            numbersList.Add(2);
            numbersList.Add(3);
            //...
            System.Console.WriteLine(numbersList);
            System.Console.WriteLine(numbersList2);
            System.Console.WriteLine(numbersList3);

            //dictionaries
            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(3, "Toki");
            names.Add(4, "Biscuit");
            names.Add(6, "Ruby");


            for (int i=1; i < names.Count; i++)
            {
                System.Console.WriteLine(names[4]);
            }

            Dictionary<int, string> names2 = new Dictionary<int, string>() 
            { 
                // dictionaries hold key value pairs
                {1, "Toki"},
                {2, "Biscuit"},
                {3, "Ruby"},    
            };

 
            

            for (int i=0; i<names2.Count; i++) 
            {
                Console.WriteLine(i);
                // pulls the keyvalue pair from index i
                KeyValuePair<int, string> namePair = names2.ElementAt(i);

                Console.WriteLine($" {namePair} {namePair.Key}  {namePair.Value}");
            }

            foreach (var pair in names2)
            {
                Console.WriteLine($" {pair.Key} {pair.Value}");
            }



            Dictionary<string, string> teachers = new Dictionary<string, string>() 
            {
                { "Math", "Toki"},
                { "Science", "Biscuit"},
                { "Chemistry", "Ruby" }
            };

            teachers.Add("Art", "Dixie");
            // if this isn't found, we get an exception!
            System.Console.WriteLine(teachers["Math"]);

            // so check first!
            if (teachers.TryGetValue("Math", out string teacher))
            {
                System.Console.WriteLine(teacher);
            } else 
            {
                System.Console.WriteLine("teacher not found");
            }

            teachers["Math"] = "Joe";  // to reassign
            teachers.Remove("math");  // this will return a boolean found or not

            if (teachers.ContainsKey("Math")) 
            {
                teachers.Remove("Math");
            } else 
            {
                System.Console.WriteLine("Math not found");
            }
            OddEven();
            arrayOfMultiples();
        }
        public static void OddEven()
        {
            var evens = new List<int>();
            var odds = new List<int>();
            for(int i=0; i<=20; i++) 
            {
                var isEven = i % 2 == 0 ? true : false;
                if (isEven) 
                {
                    evens.Add(i);
                } else
                {
                    odds.Add(i);
                }
            }
            System.Console.Write("Evens:");
            foreach(int item in evens) {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
            System.Console.Write("Odds:");
            foreach(int item in odds) {
                System.Console.Write($"{item} ");
            }
        }
        public static void arrayOfMultiples() 
        {
            Console.Write("Enter multiplier: ");
            string numInput = Console.ReadLine();
            Console.Write("Enter number of multiples: ");
            string lengthInput = Console.ReadLine();

            bool isNumberOk = false, isLengthOk = false;
            int num = 0, length = 0;
            var multiples = new List<int>();
            if (!string.IsNullOrEmpty(numInput))
            {
                isNumberOk = int.TryParse(numInput, out num);
            }
            if (!string.IsNullOrEmpty(lengthInput)) 
            {
                isLengthOk = int.TryParse(lengthInput, out length);

            }
            if (isNumberOk && isLengthOk) 
            {
                for(int i=1; i<=length; i++)
                {
                    multiples.Add(num*i);
                    Console.WriteLine($" {num*i}");
                }
            }
        }
    }
}
