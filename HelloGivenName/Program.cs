using System;

namespace HelloGivenName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            SayHello(Console.ReadLine());

            Console.Write("Enter another name: ");
            SayHello(Console.ReadLine());

            Console.Write("Enter a thrid name: ");
            SayHello(Console.ReadLine(), true);

            Console.ReadKey();
        }

        static void SayHello(string name, bool askHowAreYou = false)
        {
            Console.Write("Hello " + name + "!");

            if (askHowAreYou) 
            Console.Write(" How are you?");
            else
                Console.WriteLine();
            Console.WriteLine();
               
        }

    }
}
