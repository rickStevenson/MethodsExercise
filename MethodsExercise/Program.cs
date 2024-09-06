namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            //Add(2, 2);
            //Subtract(4, 2);
            //Multiply(5, 5);
            //Divide(20, 5);

            int result = Sum(4, 4, 4, 4, 4);
            Console.WriteLine(result);
            
        }

        protected static void MadLib()
        {
            Console.WriteLine("I'm going to tell a story. Please provide the prompts");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite Avenger?");
            string favAvenger = Console.ReadLine();
            Console.WriteLine("What is your favorite Villan?");
            string favVillian = Console.ReadLine();
            Console.WriteLine("What is your favite martial arts move?");
            string favMove = Console.ReadLine();

            Console.WriteLine($"{userName} likes wathcing {favAvenger} {favMove} {favVillian}.");
        }

        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void Subtract(int num1, int num2)
        {
            int diff = num1 - num2;
            Console.WriteLine(diff);
        }
        public static void Multiply(int num1, int num2)
        {
            int product = num1 * num2;
            Console.WriteLine(product);
        }
        public static void Divide(int num1, int num2)
        {
            double quotient = num1/ num2;
            Console.WriteLine(quotient);
        }

        public static int Sum(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }
    }
}
