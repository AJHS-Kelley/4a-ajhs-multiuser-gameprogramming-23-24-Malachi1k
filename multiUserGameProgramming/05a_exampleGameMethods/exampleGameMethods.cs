// Malachi Smith example Game Methods, v0.3

using System;

class AdventureGame
{
    // Variables
    private static int playerHealth = 100;
    private static float playerScore = 0.0f;
    private static string playerName = ""; 
    private static bool isGameOver = false; 
    private static string[] gameLocations = { "Forest", "Cave", "Castle" } 

    // Methods 
    static void Main() 
    { 
        Console.WriteLine("Welcome to the Adventure Game!"); 
        Console.Write("Enter your name: "); 
        playerName = Console.ReadLine(); 
        
        ExploreGameLocations();  
    }
    
    static void ExploreGameLocations() 
    {
         // Method to explore different game locations

          Console.WriteLine($"Hello, {playerName}! Let's explore different locations.");
           
           for (int i = 0; i < gameLocations.Length; i++) 
        { 

        Console.WriteLine($"1. Explore {gameLocations[i]}");
    }
    Console.Write("Enter your choice (1, 2, or 3): "); 
    int choice = 
    int.Parse(Console.ReadLine()); 
    
    if (choice >= 1 && choice <= gameLocations.Length) 
    {
         Console.WriteLine($"You chose to explore {gameLocations[choice - 1]}!");
        // Call another method to continue the adventure 
          ContinueAdventure(choice);
            }
            else
            }
        Console.WriteLine("Invalid choice. Please try again."); 
        // Recursive call to itself until a valid choice is made 
        ExploreGameLocations(); 
    }
}



