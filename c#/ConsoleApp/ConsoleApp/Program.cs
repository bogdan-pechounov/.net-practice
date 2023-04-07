namespace ConsoleApp
{
    public class Program
    {
        static void t1()
        {
            System.Console.WriteLine("Hi!");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello World!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        static int GetPow(int a, int b)
        {
            int result = 1;
            for(int i = 0; i< b; i++)
            {
                result *= a;
            }
            return result;
        }

        static void t2()
        {
            Console.WriteLine(GetPow(2, 5));
        }

        static void t3()
        {
            int[,] numberGrid =
            {
                {1,2,3 },
                {4,5,6 }
            };
            Console.WriteLine(numberGrid[1, 2]);
        }

        static void t4()
        {
            try
            {
                Console.Write("Enter a number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enther another number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void t5()
        {
            var book = new Book();
            book.title = "Title";

            Console.WriteLine("(" + book.author + book.pages + ")");
            Console.WriteLine(book.author == "");
            Console.WriteLine(book.author == null);

            book = new Book("Harry Potter", "JK Rowling", 400);
            Console.WriteLine("(" + book.author + book.pages + ")");
        }

        static void Main(string[] args)
        {
            t5();
        }
    }
}