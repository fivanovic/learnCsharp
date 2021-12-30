namespace learnCsharp
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            //ReadLine reads strings, numbers need to be typecast
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            //Stopped at Operators
            





        }
    }
}
