using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey(); // What happens if you run the app without this line?

            foreach (String arg in args)
            {
                if (arg == "southern")
                {
                    Console.WriteLine("Howdy Y'all!!");
                }

                if (arg == "canadian")
                {
                    Console.WriteLine("hi, how are ya?");
                }
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
