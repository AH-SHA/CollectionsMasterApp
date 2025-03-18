using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1] TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            // 2] TODO: Create an integer Array of size 50
            int[] myArray = new int[50];

            // 3] TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            ///////////////////////////////////////////////
            ///
            // See Methods section below

            Populater(myArray);
            //var randomArray = new Random();
            //Random rng = new Random();

            ////myArray = rand.Next(50);

            ////myArray{ Populater();};

            //for (int i = 0;  i < myArray.Length; i++)
            //{
            //    myArray[i] = rng.Next(0,51);
                
            //    //random(0, myArray.Length);
            //    //Populater(int[] myArray);
            //}
            //Console.WriteLine(myArray);

            //myArray.Print();

            /////////////////////////////////////////////////
            // 4] TODO: Print the first number of the array
            Console.WriteLine(myArray[0]);

            // 5] TODO: Print the last number of the array            
            Console.WriteLine(myArray[myArray.Length-1]);
            Console.WriteLine(myArray[49]);
            Console.WriteLine();

            Console.WriteLine("All Numbers Original");
            // 6] UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            // 7] TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Array.Reverse(myArray);

            Console.WriteLine(myArray);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myArray);

            Console.WriteLine("-------------------");

            // 8] TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            //for (i = 0; i < myArray.Length; i++)
            //{
            //if (i % 3 == 0)
            //{
            //i = 0;
            //}
            //else
            //{
            //i = i;

            ThreeKiller(myArray);

                                
            //}
            //Console.WriteLine(byThrees());

            //Console.WriteLine(myArray);


            Console.WriteLine("-------------------");

            // 9] TODO: Sort the array in order now
            /*      Hint: Array.____()      */


            Console.WriteLine("******Sorted Numbers:*******");
            Array.Sort(myArray);
            NumberPrinter(myArray);
            Console.WriteLine();

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            // 10 ] TODO: Create an integer List
            var create = new List<int>();

            // 11] TODO: Print the capacity of the list to the console
            Console.WriteLine(create.Capacity);

            // 12] TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(create);

            // 13] TODO: Print the new capacity
            Console.WriteLine(create.Capacity);

            Console.WriteLine("---------------------");
            ///////
            // 14] TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            bool meetCriteria;
            int searchNumber;

            do
            {
                Console.WriteLine("Enter a number:");
                meetCriteria = int.TryParse(Console.ReadLine(), out searchNumber);

            } while (!meetCriteria);

            NumberChecker(create, searchNumber);
           
            Console.WriteLine("-------------------");
            /////////
            Console.WriteLine("All Numbers:");
            // 15] UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(create);
            Console.WriteLine("-------------------");


            // 16] TODO: Create a method that will remove all odd numbers from the list then print results
            
            Console.WriteLine("Evens Only!!");

            OddKiller(create);

            Console.WriteLine("------------------");


            // 17] TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            create.Sort();
            NumberPrinter(create);

            Console.WriteLine("------------------");

            // 18] TODO: Convert the list to an array and store that into a variable

            int[] newCreateArray = create.ToArray();

            // 19] TODO: Clear the list

            create.Clear();

           

            #endregion
        }

        #region
        private static void byThrees()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 3 == 0)
                {
                    i = 0;
                }
                else
                {
                    i = i;

                }
            }
        }

        //private static void removeOdds()
        //{
            
        //    create.RemoveAt(i);
            
                
        //}

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                //else
                //{
                    //numbers[i] = numbers[i];
                //}
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> create)
        {
            for (int i = create.Count - 1; i >= 0; i--)
            {
                if (create[i] %2 != 0) 
                {
                    create.Remove(create[i]);
                }
            }

            NumberPrinter(create);
        }

        private static void NumberChecker(List<int> create, int searchNumber)
        {
            if(create.Contains(searchNumber))
            {
                Console.WriteLine("We have that number!");
            }
            else
            {
                Console.WriteLine("That number is NOT here!");
            }
        }

        private static void Populater(List<int> create)
        {
            
            Random rng = new Random();

            while (create.Count <= 50)
            {
                create.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

                        
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);

            }
            Console.WriteLine(numbers);

        }        

        private static void ReverseArray(int[] array)
        {
            var start = 0;
            var end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

    }

}
