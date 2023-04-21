namespace OverloadedMethods
{
    public class CalculateSpaceAndVolume
    {
        public int Calculate(int length, int width)
        {
            return length * width;
        }

        public int Calculate(int length, int width, int height)
        {
            return length * width *height;
        }
    }
}
