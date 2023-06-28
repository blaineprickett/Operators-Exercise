namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Exercise 1

            // Declare and Initialize variables
            int a = 17;
            int b = 4;

            // Calculate quotient and remainder
            int quotient = a / b;
            int remainder = a % b;

            // Exercise 2

            // Prompt the user to enter the radius of the circle
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            // Call the AreaOfCircle method to calculate the area
            double area = AreaOfCircle(radius);

            // Output the calculated area
            Console.WriteLine();
            Console.WriteLine($"The area of the circle is: {area}");

            // Check condition using if statement
            if (a == 17 && b == 4)
            {
                // Output the result using string interpolation
                Console.WriteLine();
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            // Method to calculate the area of a circle
            static double AreaOfCircle(double radius)
            {
                // Calculate the area using the formula: PI * radius * radius
                return Math.PI * radius * radius;
            }
        }
    }
}
