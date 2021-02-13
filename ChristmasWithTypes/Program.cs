using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Friday;

            //done set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //done Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{"Xbox", "Nintendo Switch", "iPhone X" }; 

            //done Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            //$ string interpolation - 

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            /*the target framework netcoreapp3.0 is out of support*/
            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
