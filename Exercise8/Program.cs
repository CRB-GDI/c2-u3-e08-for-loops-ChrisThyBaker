namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking for input in int for the maximum number the loop will read 
            Console.WriteLine("enter an int for the maximum number printed");
            int LoopEnd = int.Parse(Console.ReadLine());

            //starting number in the loop
            int a = 0;

            //loop
            for (a = a; a <= LoopEnd; a++)
            {
                //print only even numbers in the loop
                if (0 == a % 2)
                {
                    Console.WriteLine(a);
                }
            }

            //asking for the amount of asterisks that they want in a row
            bool AnotherRow = true;

            while (AnotherRow == true)
            {
                //asking for the amount of asterisks that they want in a row
                Console.WriteLine("enter the number asterisks you want in a row");
                int NumberOfAsterisks = int.Parse(Console.ReadLine());

                //printing the Amount of Asterisks in that row
                for (NumberOfAsterisks = NumberOfAsterisks; NumberOfAsterisks > 0; NumberOfAsterisks--)
                {
                    Console.Write("*");
                }

                //makes a sapce between the printed asterisks and the want another row 
                Console.WriteLine(" \n");

                //ask if they want another row of asterisks
                Console.WriteLine("want another row? : enter ture or false");
                AnotherRow = bool.Parse(Console.ReadLine());

            }
        }
    }
}