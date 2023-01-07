namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Select the Program\n1.Flip Coin\n2.LeapYear\n3.PowerOfTwo\n4.HarmonicValue\n5.Factors\n6.QuotientRemainder\n7.SwapNumber");
            Console.WriteLine("Choose option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.FlipCoins();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.CheckLeapYear();
                    break;
                case 3:                   
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.PowerOf2();
                    break;
                case 4:
                    HarmonicValue harmonicValue = new HarmonicValue();
                    harmonicValue.checkHarmonicValue();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactors();
                    break;
                case 6:
                    QuotientRemainder quotientRemainder = new QuotientRemainder();
                    quotientRemainder.findQuotientAndRemainder();
                    break;
                case 7:
                    SwapNumbers swapNumbers = new SwapNumbers();
                    swapNumbers.Swap();
                    break;
            }
        }
    }
}