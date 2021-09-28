using System;
using System.Collections.Generic;

namespace cd_c_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] array1;
            array1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names;
            names = new string[] {"Tim", "Martin", "Nikki", "Sara"};


            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] array2 = {true, false, true, false, true, false, true, false, true, false};

            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Jersey Shore");
            flavors.Add("Black Squirrel");
            flavors.Add("Yeti");
            flavors.Add("Sasquatch");
            flavors.Add("Mint Chocolate Chip");

            // Output the length of this list after building it
            System.Console.WriteLine(flavors.Count);

            // Output the third flavor in the list, then remove this value
            System.Console.WriteLine(flavors[2]);
            flavors.Remove("Yeti");

            // Output the new lenght of the list (it should just be one fewer!)
            System.Console.WriteLine(flavors.Count);

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> iceCream = new Dictionary<string, string>();

            // Add key/value paris to this dictionary where:
            //      -> each key is a name from your names array
            //      -> each value is a randomly select a flavor from your flavors list
            var random = new Random();
            int index = random.Next(flavors.Count);
            iceCream.Add($"{names[0]}", $"{flavors[3]}");
            iceCream.Add($"{names[1]}", $"{flavors[0]}");
            iceCream.Add($"{names[2]}", $"{flavors[1]}");
            iceCream.Add($"{names[3]}", $"{flavors[2]}");

            // Attempt to randomize flavor index **ASK HOW TO MAKE IT CONTINUALLY RANDOM, instead of all same flavor**
            //iceCream.Add($"{names[2]}", $"{flavors[index]}");
            
            

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string, string> entry in iceCream)
            {
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
