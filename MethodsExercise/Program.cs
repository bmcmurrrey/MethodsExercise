namespace MethodsExercise
{
    public class Program
    {public static int sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
    public static int multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
    public static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {//exercise 1
            Console.WriteLine($"Hello! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine($"{userColor} is a nice color, What is your favorite Animal?");
            string userAnimal = Console.ReadLine();
            
            Console.WriteLine($"{userAnimal}s are awesome! What is your favorite music artist or band?");
            string userArtist = Console.ReadLine();
            
            Console.WriteLine($"There was a person named {userName} and their favorite color is {userColor}.");
            Console.WriteLine($"{userName} is a big fan of {userAnimal}s, and thinks that they are awesome!");
            Console.WriteLine($"{userName}'s favorite music artist to listen to is {userArtist}");

        }
    }
}
