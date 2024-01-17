using rolling_dice;
using System.Numerics;

internal class Roll_Dice
{
    private static void Main(string[] args)
    {
        Simulation sim = new Simulation();
        
        int rolls;
        int[] results;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("");

        System.Console.Write("How many dice would you like to roll? ");
        rolls = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
        System.Console.WriteLine("Total number of rolls = " +  rolls);
        System.Console.WriteLine("");


        results = sim.Simulate(rolls); // Returns an array of the simulation

        for (int i = 0; i < results.Length; i++)
        {
            double stars;
            int num;
            
            if (i == 0 | i == 1)
            {
                continue;
            } 
            else
            {
                num = results[i];
                stars = Math.Round(((double)num / rolls) * 100);
                string added_stars = "";
                for (int j = 0; j < stars; j++)
                {
                    added_stars += '*';
                }
                System.Console.WriteLine(i + ": " + added_stars);
            }
        }
        
        System.Console.WriteLine("");
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    
    }
}