using System.Security.Cryptography;

namespace mission001real

{
    public class DiceSimulator
    {
        int[] numArray = new int[11];

        public void twoDiceRoll()
        {
            int die1;
            int die2;
            int rolltotal;
            
            Random random = new Random();
            die1 = random.Next(1, 7); // Random number for die1 (1 to 6)
            die2 = random.Next(1, 7); // Random number for die2 (1 to 6)

            rolltotal = die1 + die2;

            numArray[(rolltotal - 2)] = numArray[(rolltotal - 2)] + 1;

        }

        public void DieResults(int numDie)
        {
            for (int i = 0; i < numDie; i++)
            {
                twoDiceRoll();
            }
            
        }

        public void displayStats(int numDie)
        {
            for (int count = 0; count <= 10; count++)
            {
                int stars;
                // Calculate percentage as a double to preserve precision
                double percentage = (double)numArray[count] / numDie * 100;

                // Calculate stars and ensure at least 1 star for non-zero values
                stars = (int)Math.Round(percentage);
                if (stars == 0 && numArray[count] > 0)
                {
                    stars = 1; // Ensure at least 1 star for values greater than 0
                }
                // Access the array element corresponding to the current dice total
                System.Console.WriteLine($"{count + 2}: {new string('*', stars)}");
            }
        }
    }
}