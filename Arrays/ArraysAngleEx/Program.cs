namespace ArraysAngleEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int angleCount = 3;
            int[] angles = new int[angleCount];

            for(int i = 0; i < angleCount; i++)
            {
                Console.WriteLine("Enter angle " + (i + 1) + ": ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine($"Sum of angles : {angleSum}");

            if (angleSum == 180)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Console.WriteLine(angleSum == 180? "Valid" : "Invalid");
        }
    }
}
