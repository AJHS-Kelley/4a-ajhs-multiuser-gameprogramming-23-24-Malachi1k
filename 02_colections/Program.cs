// 02_collections, Malachi smith, 10-04-23 v0.6a
using System;

namespace _02_colections
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CANNOT change.
            -- Contents of elements in an array CAN change.
            -- Items in the array are called ELEMENTS.
            -- Arrays are ordered, meaning each item has a fixed position.
            -- The position is known as the INDEX.
            -- First element in an array is index 0.
            

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pankcakes", "Cereal", "Parfait" };
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

            // Print Array Contents -- All Elements on Single Line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(",", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(",", GPA));
            Console.WriteLine();

        }   /* Print Array Contents -- Each Element on Seperate Line
    }        Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join("\n", GPA));
            Console.WriteLine();
}           */

            /* determine Array Length
            Console.WriteLine("The length of each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods.Length);
            Console.WriteLine("testScores: " + testScores.Length);
            Console.WriteLine("GPA: " + GPA.Length);

            // Accessing Array Elements -- ues the index!
            Console.WriteLine("The first element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[0]);
            Console.WriteLine("testScores: " + testScores[0]);
            Console.WriteLine("GPA: " + GPA[0]);
        
            // Access Last Element
            Console.WriteLine("The last element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[breakfastFoods.Length - 1]);
            Console.WriteLine("testScores: " + testScores[testScores.Length - 1]);
            Console.WriteLine("GPA: " + GPA[GPA.Length - 1]);
     
            // PWYOC -- Pause write your own code
            // v0.2b -- Access the third element in each array and print to the screen.
            Console.WriteLine("The third element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[2]);
            Console.WriteLine("testScores: " + testScores[2]);
            Console.WriteLine("GPA: " + GPA[2]);
            */

            /* Changing Array Elements -- 
            breakfastFoods[0] = "Fried Squid";
            testScores[0] = 59;
            GPA[0] = 1.34f;
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(",", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(",", GPA));
            Console.WriteLine();

            // PWYOC -- update fifth Elememnt from Each Array
            breakfastFoods[4] = "Corn Pops Cereal";
            testScores[4] = 0;
            GPA[4] = 2.75f;
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(",", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(",", GPA));
            Console.WriteLine();

            // Common Bugs working with arrays.
            // Index Out of Bounds -- Accessing an that does not exist.
            //Console.WriteLine(breakfastFoods[4]);  

            // Incorrect Data Type 
            // testScores[0] = "Billy"; // If possible, use the correct Convert.() If not possible, manually change to correcr data type.

            // Common Array Methods - Sort() -- Sorts in alphabetical or numeric order, ascending. 
            int[] newIntArr = {25, -25, 0, -10, 15, 50, -35, 75, -155, 95, -65, 85};
            string[] newStringArr = {"Zebra", "Aardvark", "Emu", "Cow", "Frog", "Platypus", "Gorilla", "Ibis","Horse"};
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("newIntArr: \n" + String.Join(",", newIntArr));
            Console.WriteLine();
            Console.WriteLine("newStringArr: \n" + String.Join(",", newStringArr));
            Console.WriteLine();

            // Sort() Each Array
            Array.Sort(newIntArr);
            Array.Sort(newStringArr);
            Console.WriteLine("The SORTED elements for each array are:\n");
            Console.WriteLine("newIntArr: \n" + String.Join(",", newIntArr));
            Console.WriteLine();
            Console.WriteLine("newStringArr: \n" + String.Join(",", newStringArr));
            Console.WriteLine();
            

            // Common Array Methods - Min(), Max(), and Sum()
            Console.WriteLine("The minimum value for newIntArr is:");
            Console.WriteLine(newIntArr.Min());
            Console.WriteLine("The maxium value for newIntArr is:");
            Console.WriteLine(newIntArr.Max());
            Console.WriteLine("The sum value for newIntArr is:");
            Console.WriteLine(newIntArr.Sum());
            */

            // Create ArrayList -- Array that can have items added/deletd AND changed
            var myArrayList = new ArrayList();
            // Add items to ArrayList - .Add()
            myArrayList.Add(5);
            myArrayList.Add("First Name");
            myArrayList.Add(true);
            myArrayList.Add(0.0f);

            Console.WriteLine(myArrayList[0]);
            Console.WriteLine(myArrayList[1]);
            Console.WriteLine(myArrayList[2]);
            Console.WriteLine(myArrayList[3]);

            // Create ArrayList with Values
            var myArrayList2 = new ArrayList()
            {
                -10, "Last Name", false, 0.25f
            };
            Console.WriteLine(myArrayList[0]);
            Console.WriteLine(myArrayList[1]);
            Console.WriteLine(myArrayList[2]);
            Console.WriteLine(myArrayList[3]);
        
            // ArrayList Methods -- .Tnsert(index, value)
            myArrayList2.Insert(1, "First Name");
            Console.WriteLine(myArrayList2[1]);
            Console.WriteLine(myArrayList2[2]);

            // Removing Items from ArrayList -- .Removee() Deletes FIRST OCCURENCE of the item.
            myArrayList2.Remove(-10);
            Console.WriteLine(myArrayList2[0]);

            // .RemoveAt(value) -- Deletes at the specified index value.
            Console.WriteLine(".RemoveAt() Example");
            Console.WriteLine(myArrayList2[3]);
            myArrayList2.RemoveAt(3);
            Console.WriteLine(myArrayList2[3]);

            // .RemoveRange(value0, value1) -- Deletes items in the specified index range.
            Console.WriteLine(".RmoveRange() Example");
            
            myArrayList2.RemoveRange(2, 4); // Remove index 2, 3, and 4.
