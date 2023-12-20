// Malachi Smith example Game Methods, v0.2

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



