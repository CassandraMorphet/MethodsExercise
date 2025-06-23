namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name? ");
            string username = Console.ReadLine();

            Console.WriteLine($"Hello, {username}! What is your favorite color? ");
            string favColor = Console.ReadLine();

            Console.WriteLine($"{favColor} is a great color! What is your favorite animal? ");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"Wow! {favAnimal}, cool choice. Who's your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"As {username} slept and dreamnt of a {favColor} {favAnimal}, thinking it was strange decided to keep going through the meadow, and then came across a sound. Creeping closer to the field, it turned out to be {favBand}! Then becoming so overjoyed, {username} woke up springing out of bed!");

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {

            return num1 / num2;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            MadLib();
            Console.WriteLine(Add(num1: 2, num2:2));
            int addedNums = Add(2, 2);
            Console.WriteLine(addedNums);
            Console.WriteLine(Subtract(num1:2, num2:2));
            Console.WriteLine(Multiply(num1:2, num2:2));
            Console.WriteLine(Divide(num1:2, num2:2));
            Console.WriteLine(Sum(5, 5, 5));
        }
    }
}
