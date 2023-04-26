﻿using System;
using System.Collections.Generic;

namespace DataTypes {

    class Program {

        static void Main(string[] args) {

            // //* Declaring an array of length 5, initialized by default to all zeroes
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

            // //* Initializing an empty list of Stuff
            List<string> someStuff = new List<string>();

            //* Use the Add function in a similar fashion to push
            someStuff.Add("Cigarettes");
            someStuff.Add("Liquor");
            someStuff.Add("Lighter");
            someStuff.Add("Badge");
            someStuff.Add("Laptop");
            // //* Accessing a generic list value is the same as you would an array
            // Console.WriteLine(someStuff[2]); //Prints "BMW"
            // Console.WriteLine($"We currently know of {someStuff.Count} items in your backpack.");

            //* Using our array of motorcycle manufacturers from before
            //* we can easily loop through the list of them with a C-style for loop
            //* this time, however, Count is the attribute for a number of items.
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < someStuff.Count; idx++) {
                Console.WriteLine("-" + bikes[idx]);
            }
            //*  Insert a new item between a specific index
            someStuff.Insert(2, "Yamaha");
            //* Removal from Generic List
            //* Remove is a lot like Javascript array pop, but searches for a specified value
            //* In this case we are removing all manufacturers located in Japan
            someStuff.Remove("Suzuki");
            someStuff.Remove("Yamaha");
            someStuff.RemoveAt(0); //RemoveAt has no return value however
            //* The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in someStuff)
            {
                Console.WriteLine("-" + manu);
            }


        }
        
    }
}
