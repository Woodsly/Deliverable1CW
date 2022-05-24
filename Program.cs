using System;

namespace ConsoleApp1
{
    internal class Program
    {
      
           
            static void Main(string[] args)
            {
            string rerun = "Y";
            do
            {
                Console.WriteLine("Hello, How many people are we making PB and J's for?");
                double PeoplePBJ = int.Parse(Console.ReadLine());
                double Bread = PeoplePBJ * 2;
                double PB = PeoplePBJ * 2;
                double jelly = PeoplePBJ * 4;
                Console.WriteLine("You need: ");
                Console.WriteLine(Bread + " slices of bread");
                Console.WriteLine(PB + " tablespoons of peanut butter");
                Console.WriteLine(jelly + " teaspoons of jelly");
                Console.WriteLine("Which is...");
                double Loaves_bread = (Bread / 28);
                double Loaves_round = Math.Ceiling(Loaves_bread);
                double jarspb = PB / 32;
                double jarsround = Math.Ceiling(jarspb);
                double jarjel = jelly / 48;
                double jarsjround = Math.Ceiling(jarjel);
                Console.WriteLine(Loaves_round + " loaves of bread");
                Console.WriteLine(jarsround + " jars of peanut butter");
                Console.WriteLine(jarsjround + " jars of jelly");
                Console.WriteLine("Would you like to run the program again?");
                rerun = Console.ReadLine().ToUpper();
            


            } while (rerun == "Y" || rerun == "YES");
            Console.WriteLine("Goodbye");

            }

              

            
            
    }
}
