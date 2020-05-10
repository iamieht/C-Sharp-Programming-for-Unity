using System;

namespace ProgrammingAssignment1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /// Program Assignment 1:
            /// Calculate the distance between two points and the angle
            /// between them

            Console.WriteLine("Welcome. We are going to calculate the distance between two points and the angle between them");

            Console.Write("Enter first x value: ");
            float firstXvalue = float.Parse(Console.ReadLine());

            Console.Write("Enter first y value: ");
            float firstYvalue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter second x value: ");
            float secondXvalue = float.Parse(Console.ReadLine());

            Console.Write("Enter second y value: ");
            float secondtYvalue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            // Calculate delta values between points

            float deltaX = secondXvalue - firstXvalue;
            float deltaY = secondtYvalue - firstYvalue;

            // Calculate distance and angle between points

            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            float angleRadians = (float)Math.Atan2(deltaY, deltaX);

            // Convert angle from radians to degrees
            float angleDegrees = angleRadians * (180/(float)Math.PI);

            // Print the result

            Console.WriteLine("The distance between the two points is " + distance);
            Console.WriteLine("The angle between the two points is " + angleDegrees + " degrees");
            Console.WriteLine();


        }
    }
}
