using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace ReviewMethodOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make sure you know how to apply all of these concepts before moving on!

Call DecoratePlanet() with the argument destination.

Store the returned value in the variable welcomeMessage.*/
            // Define variables
            string destination = "Neptune";
            string galaxyString = "8";
            int galaxyInt;
            string welcomeMessage;
            bool outcome;

            // Call DecoratePlanet() and TryParse() here
            welcomeMessage = DecoratePlanet(destination);
            outcome = Int32.TryParse(galaxyString, out galaxyInt);

            // Print results
            Console.WriteLine(welcomeMessage);
            Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
            /*Call Int32.TryParse(), using galaxyString and galaxyInt as arguments.

Store the returned value in the variable outcome.*/

        }

        // Define a method that returns a string
        static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        // Define a method with out
        static string Whisper(string phrase, out bool wasWhisperCalled)
        {
            wasWhisperCalled = true;
            return phrase.ToLower();
        }
    }
}

