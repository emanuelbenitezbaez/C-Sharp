namespace ExercisePasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ask user to enter a password and store
            Ask user to enter a password again and store
            Check if both passwords contains something
            if so, check if they are the same
               if they are print "Password match"
               if they dont print "Password missmatch"
            if they are empty print "Please enter a password"
             */

            Console.WriteLine("Enter your password:");
            string? pass1 = Console.ReadLine();
            Console.WriteLine("Enter your password again:");
            string? pass2 = Console.ReadLine();

            bool  isNullOrEmpty1 = string.IsNullOrEmpty(pass1);
            bool isNullOrEmpty2 = string.IsNullOrEmpty(pass2);

            if (isNullOrEmpty1 || isNullOrEmpty2)
            {
                Console.WriteLine("Null or empty, please enter a password.");
            }
            else if (pass1 !=null && pass1.Equals(pass2))
            {
                Console.WriteLine("Password Match!");
            }
            else
            {
                Console.WriteLine("Password Missmatch!");
            }
          



        }
    }
}
