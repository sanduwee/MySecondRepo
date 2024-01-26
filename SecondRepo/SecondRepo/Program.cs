namespace SecondRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 10;
            for(int i = 0; i < 10; i++)
            {
                x = x + i;
                Console.WriteLine(x);
            }
        }
    }
}