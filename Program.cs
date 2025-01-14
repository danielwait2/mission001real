// See https://aka.ms/new-console-template for more information

using mission001real;

internal class Program
{
    public static void Main(string[] args)
    {
        int numOfDie = 0;
        
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine();
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        numOfDie = int.Parse(System.Console.ReadLine());

        DiceSimulator simulator = new DiceSimulator();

        simulator.DieResults(numOfDie);
        
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + numOfDie + ".\n");
        
        simulator.displayStats(numOfDie);
        
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}