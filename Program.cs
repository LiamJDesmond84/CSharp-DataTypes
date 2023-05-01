using System;
using System.Collections.Generic;

namespace DataTypes {

    class Program {

        public static void SayHello(string firstName = "Fool") {
            Console.WriteLine($"Hello, {firstName}, how are you doing today?");
        }

        public static string SayHello2(string firstName = "Fool") {
            return $"Hello, {firstName}, how are you doing today?";
        }


        static void Main(string[] args) {
            //* We can call it without providing any arguments and the default value will be used...
            // SayHello("Sucka");
            //* ...or we can call it with an argument and that argument's value will be use
            // SayHello();

            string output;

            output = SayHello2("Sucka");
            Console.WriteLine(output);

            //# arrays
            // //todo Declaring an array of length 5, initialized by default to all zeroes
            // int[] numArray = new int[5];
            // //* Declaring an array with pre-populated values
            // //* For Arrays initialized this way, the length is determined by the size of the given data
            // int[] numArray2 = {1,2,3,4,6};

            // //* Declaring an array without a set length, then initialize it after
            // int[] array3;
            // array3 = new int[] {1,3,5,7,9};


            // int[] arrayOfInts = {1, 2, 3, 4, 5};
            // Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            // Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            // Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            // Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
            // Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.

            // int[] arr = {1, 2, 3, 4};
            // Console.WriteLine($"The first number of the arr is {arr[0]}"); 
            // arr[0] = 8;
            // Console.WriteLine($"The first number of the arr is now {arr[0]}");
            // // The array has now changed!

            // string[] myStuff = new string[] { "Uno", "Dos", "Tres", "Quatro", "Cinco"};

            // for(int x = 0; x < myStuff.Length; x++){

            //     Console.WriteLine($"Numero {myStuff[x]}");

            // }

            // foreach(string x in myStuff){

            //     //* We no longer need the index, because variable 'x' already represents each indexed value
            //     Console.WriteLine($"Numero {x}....  Again");
            // }
            //# Lists
            // //* Initializing an empty list of Stuff
            // List<string> someStuff = new List<string>();

            // //* Use the Add function in a similar fashion to push
            // someStuff.Add("Cigarettes");
            // someStuff.Add("Liquor");
            // someStuff.Add("Lighter");
            // someStuff.Add("Badge");
            // someStuff.Add("Laptop");
            // // //* Accessing a generic list value is the same as you would an array
            // // Console.WriteLine(someStuff[2]); //Prints "BMW"
            // // Console.WriteLine($"We currently know of {someStuff.Count} items in your backpack.");

            // //* Using our array of motorcycle manufacturers from before
            // //* we can easily loop through the list of them with a C-style for loop
            // //* this time, however, Count is the attribute for a number of items.
            // Console.WriteLine("The current manufacturers we have seen are:");
            // for (var idx = 0; idx < someStuff.Count; idx++) {
            //     Console.WriteLine("-" + someStuff[idx]);
            // }
            // //*  Insert a new item between a specific index
            // someStuff.Insert(2, "BMF-Wallet");
            // //* Removal from Generic List
            // //* Remove is a lot like Javascript array pop, but searches for a specified value
            // //* In this case we are removing all manufacturers located in Japan
            // someStuff.Remove("Laptop");
            // someStuff.Remove("BMF-Wallet");
            // someStuff.RemoveAt(0); //RemoveAt has no return value however
            // //* The updated list can then be iterated through using a foreach loop
            // Console.WriteLine("List of Non-Japanese Manufacturers:");
            // foreach (string manu in someStuff) {
            //     Console.WriteLine("-" + manu);
            // }


            //# Dictionaries
            Dictionary<string,string> profile = new Dictionary<string,string>();
            //* Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Sucka");
            profile.Add("Language", "C#");
            profile.Add("Location", "San Diego");
            // Console.WriteLine("Instructor Profile");
            // Console.WriteLine("Name - " + profile["Name"]);
            // Console.WriteLine("From - " + profile["Location"]);
            // Console.WriteLine("Favorite Language - " + profile["Language"]);

            // foreach (KeyValuePair<string,string> x in profile) {
            //     Console.WriteLine(x.Key + " - " + x.Value);
            // }

            // //* The var keyword takes the place of a type in type-inference
            // foreach (var entry in profile) {
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }

            // //# Debugger test
            // string test = "TEST";

            // Console.WriteLine(test);

            // Console.WriteLine(args);

            //# Final
            // int[] nums = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            // string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            // bool[] bools = new bool[10];
            // bools[0] = true;
            // bools[1] = true;
            // bools[2] = false;
            // bools[3] = true;
            // bools[4] = false;
            // bools[5] = false;
            // bools[6] = true;
            // bools[7] = true;
            // bools[8] = false;
            // bools[9] = true;

            // List<string> flavors = new List<string>();
            // flavors.Add("Chocalate");
            // flavors.Add("Vanilla");
            // flavors.Add("Strawberry");
            // flavors.Add("Dunno");
            // flavors.Add("Don't Care");

            // Console.WriteLine(flavors.Count);
            // Console.WriteLine("Third Flavor: " + flavors[2]);
            // flavors.Remove("Strawberry");
            // Console.WriteLine(flavors.Count);


            // Dictionary<string, string> dict = new Dictionary<string, string>();
            // dict.Add(names[0], flavors[0]);
            // dict.Add(names[1], flavors[1]);
            // dict.Add(names[2], flavors[2]);

            // foreach(KeyValuePair<string, string> x in dict){
            //     Console.WriteLine("User:" + x.Key + " - Favorite Flavor: " + x.Value);

            // }


            //# Multidimensional arrays
            //* Multidimensional array declaration

            //* This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            // int [,] array2D = new int[3,2];
            // //* This is equivalent to:
            // //*  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
            
            // //*/ This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            // //todo int[,,] array3D = new int[2,3,4] { {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },{  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }};
            // int[,,] array3D = new int[2,3,4] 
            //     {
            //         {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
            //         {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
            //     };
            // //* Directly accessing a multidimensional array
            // Console.WriteLine(array2D[0,1]);   // prints 0
            // Console.WriteLine(array3D[1,0,3]); // prints 42

            //# Jagged arrays

            //* Jagged array declaration
            int[][] jaggedArray = new int[3][];
            //* Instantiating each inner array with a different set length
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4]; 
            jaggedArray[2] = new int[2];

            int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44},
                new int[] {14,22,57,69,62,99}
            };

            //* Short-hand form
            int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            //* You can even mix jagged and multi-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,] 
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} } 
            };

            //* Working through each array in a jagged array
            // foreach(int[] innerArr in jaggedArray){
            //     Console.WriteLine("Inner array length is {0}", innerArr.Length);
            // }
            // //* Accessing a jagged array
            // Console.WriteLine(jaggedArray2[0][1]); // 3
            // Console.WriteLine(jaggedArray3[2][3]); // 44

            //# Type Casting

            //* Implicit Casting
            int IntegerValue = 65;
            double DoubleValue = IntegerValue;
            // Console.WriteLine(DoubleValue); // DoubleValue == 65

            //* Explicit Casting
            double DoubleValue2 = 3.14159265358;
            int IntegerValue2 = (int)DoubleValue2;
            // Console.WriteLine(IntegerValue2); // IntegerValue2 == 3


            double floatNum = 7.76; 
            //! This will cause a compiler type-mismatch error!!
            //! int num = floatNum;
 
            //* Floating point to integer conversion truncates all numbers after the decimal
            int num = (int)floatNum;
            // Console.WriteLine(num); // num == 7

            //# Converting an integer to a string
            int num2 = 7;
            string numAsString = num2.ToString();
            // Console.WriteLine(numAsString); // numAsString == "7"

            //# Converting an string to an integer
            string stringNum = "8";
            int num3 = int.Parse(stringNum);
            //* Console.WriteLine(num3); // num3 == 8


            //# Boxing/Unboxing

            //? Safely Unboxing

            //* Box some string data into a variable
            object BoxedData = "This is clearly a string";

            //* Make sure it is the type you need before proceeding
            if (BoxedData is int) {
                //* This shouldn't run
                // Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (BoxedData is string) {
                // Console.WriteLine("It is totally a string in the box!");
            }

            //? Safe Explicit Casting

            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;
            
            //! THIS WON'T WORK!!
            //! object ActuallyInt = 256;
            //! int ExplicitInt = ActuallyInt as int;

            List<object> obj = new List<object>();

            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");


            // for(int x = 0; x < obj.Count; x++){

            //     Console.WriteLine(obj[x]);
            // }

            // int sum = 0;

            foreach(var x in obj){

            //     if(x is int){
            //         sum += (int)x;
                    
            //     }
            //     Console.WriteLine("Sum: " + sum);
            }

            //# Functions


        }

        
    }
}
