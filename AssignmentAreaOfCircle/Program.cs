/*
Write a C# program to calculate "area of circle" based on the given "radius" value.
The radius value can be assigned to a variable; need not to take the value from the keyboard input.

Formula: PI * radius * radius

PI is a constant value, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter. 
*/

namespace AssignmentAreaOfCircle
{
	class Program
	{
		static void Main()
		{
			// Inputs
			double PI = 3.14159;
			System.Console.WriteLine("What is the radius of the circle?");
			int radius = int.Parse(System.Console.ReadLine());

			// Process
			double area = PI * radius * radius;

			// Output
			System.Console.WriteLine("\nThe area of the circle is " + area);
			System.Console.Read();
		}
	}
}
