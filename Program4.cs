using System;
using System.Linq;

namespace learnCsharp

{
    class Program4
    {

        static void MyMethod()
        {
            Console.WriteLine("Executed");
        }

        static void nametime(string fname = "Charles")
        {
            //if called without arguement, it uses the default value
            Console.WriteLine("The name is " + fname);
        }

        static int addFive(int x)
        {
            return 5 + x;
        }

        //methods can be overloaded 
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //functions in c# are called methods
            MyMethod();
            
            nametime("James");
            nametime();
            Console.WriteLine(addFive(4));
            int num1 = addFive(6);




        }
    }
}
