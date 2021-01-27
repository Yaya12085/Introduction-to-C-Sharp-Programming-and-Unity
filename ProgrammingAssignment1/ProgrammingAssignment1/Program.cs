using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        // x and y coordinates for points
        static float point1X;
        static float point1Y;
        static float point2X;
        static float point2Y;

        /// <summary>
        /// Calculates angle and distance between two points
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract point coordinates from string
                GetInputValuesFromString(input);

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

               		    Console.WriteLine("Provide coorinate X of the first point");
			    float point1X = float.Parse(Console.ReadLine());
			    Console.WriteLine("Provide coorinate Y of the first point");
			    float point1Y = float.Parse(Console.ReadLine());
			    Console.WriteLine("Provide coorinate X of the second point");
			    float point2X = float.Parse(Console.ReadLine());
			    Console.WriteLine("Provide coorinate Y of the second point");
			    float point2Y = float.Parse(Console.ReadLine());


			float deltaX = point1X - point2X;
			float deltaY = point1Y - point2Y;

			float hypotenuse = (float) Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

			float angleInRadians = (float) Math.Atan2(deltaY, deltaX);
			float angleInDegrees = angleInRadians * 180 / (float) Math.PI - 180;

			Console.WriteLine("The deltaX: " + deltaX);
			Console.WriteLine("The deltaY: " + deltaY);
                        Console.WriteLine("The distance between the two points is: " + hypotenuse);
			Console.WriteLine("The angle between the two points (in degrees): " + angleInDegrees);
			Console.ReadLine();




                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts point coordinates from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValuesFromString(string input)
        {
            // extract point 1 x
            int spaceIndex = input.IndexOf(' ');
            point1X = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 1 y
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point1Y = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 2 x
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point2X = float.Parse(input.Substring(0, spaceIndex));

            // point 2 y is the rest of the string
            input = input.Substring(spaceIndex + 1);
            point2Y = float.Parse(input);

            #region Unfortunately, Mono doesn't have a Split method!
            //string[] values = input.Split(' ');
            //point1X = float.Parse(values[0]);
            //point1Y = float.Parse(values[1]);
            //point2X = float.Parse(values[2]);
            //point2Y = float.Parse(values[3]);
            #endregion

        }
    }
}
