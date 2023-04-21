namespace OverloadedMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSpaceAndVolume calculateSpaceAndVolume = new CalculateSpaceAndVolume();

            // Calculating Space with overload method
            int space = calculateSpaceAndVolume.Calculate(2, 4);
            Console.WriteLine("Space is " + space);
            int volume = calculateSpaceAndVolume.Calculate(3, 5, 7);
            Console.WriteLine("Volume is " + volume);
            Console.ReadKey();
        }
    }
}