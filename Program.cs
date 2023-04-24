using System;

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

            string[] myStuff = new string[] { "Uno", "Dos", "Tres", "Quatro", "Cinco"};

            for(int x = 1; x < myStuff.Length; x++){

                Console.WriteLine(myStuff[x]);

            }

        }
        
    }
}
