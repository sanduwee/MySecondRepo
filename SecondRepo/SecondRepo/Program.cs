namespace SecondRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int variableX = 10;
            for(int i = 0; i < 10; i++)
            {
                variableX = variableX + i;
                Console.WriteLine(variableX);
            }
        }
    }
}