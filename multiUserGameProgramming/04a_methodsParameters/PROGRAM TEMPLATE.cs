// Malachi Smith, Program Template, v0.06
using System; 
/*
Missing Examples
Method with Multiple Parameters
Method with Default Parameters
Method Class using Named Arguments
Method Overloading 
*/ 

namespace MethodsParameters
{
    class MethodsParameters
    {
            // METHOD -- named block of code, can used over and over.
            // All methods have a SIGNATURE that defines their name, parameters, and output.
            // Example Signature 

            static void MyMethod()
            {
                Console.WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and french fried ")
            }
            // static -- This method belongs to the current class, it is NOT an object 
            // void -- This method has no return value.

            static int DoubleUp():
            {
                int sum = 0;
                Console.WriteLine("This method will double a number and return it.\n")
                Console.WriteLine("Please enter a number on the next line.\n")
                sum = System.Convert.ToInt32(Console.ReadLine());
                //sum *= 2;
                //Console.WriteLine(sum);
                returm sum;
        }
       
       
        static void MakePancakes(int num)
    
            for (int i = 0; i < num; i++)
            {

            Console.WriteLine("one golden, Fluffy pancake coming up!\n");
            
            }

        }
       
        static void MakeEggs(int num, string style)
        {  
            Console.WriteLine("you have orrdered" + num + "eggs cooked" + style + ".\n");
        }
        
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("i am going to cook " + num + "hamburgers.\n");
        }

        static void AllMyChildren(string child1, string child2, string child3)
        {
             Console.WriteLine("my favorite child is " + child3);
        }


         static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: "+ sum);
            return sum;
        }


        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: "+ sum);
            return sum;
        }