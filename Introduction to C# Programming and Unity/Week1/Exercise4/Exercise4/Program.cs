using System;

namespace Exercise4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first altitude");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude");
            int secondAltitude = int.Parse(Console.ReadLine());

            int altitudeChange;
            altitudeChange = secondAltitude - firstAltitude;

            Console.WriteLine("Altitude Change is " + altitudeChange);
        }
    }
}
