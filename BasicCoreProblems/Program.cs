namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Select the Program\n1.Flip Coin");
            Console.WriteLine("Choose option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UseCases usecases = new UseCases();
                    usecases.FlipCoin();
                    break;
            }
        }
    }
}