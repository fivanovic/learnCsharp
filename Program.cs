namespace learnCsharp
{
    class Program
    {
        static void notMain(string[] args)
        {
            string name = "John";
            Console.WriteLine(name);
            // console.write will write all text on a single line 
            /* 
            this is how you do multiline comments
            */

            int myNum = 15;
            Console.WriteLine(myNum);
            myNum = 16;
            Console.WriteLine(myNum);

            const int myNumC = 20; // this cannot be changed. a value must be rovided alongside const '
            Console.WriteLine(myNumC);

            double myDouble = 5.99D;
            char myLetter = 'D';
            bool myBool = true;

            string myText = "Hello";

            Console.WriteLine(myText + ' ' + name);
            //+ is the mathematical operator when used with ints or doubles
            Console.WriteLine(myNum + myDouble);

            int x = 5, y = 2, z = 4;
            //float stores 6-7 decimal points, double stores 15 
            //long stores bigger numbers than int (in both directions!)

            float myFloat = 7.75F; // floats need to be defined with an F after the number 
            // doubles can have D ater the number, but it is not necessary

            float f1 = 35e-3F; // e can be used to indicate the power of 10
            Console.WriteLine(f1);

            bool isCorrect = true;

            Console.WriteLine(isCorrect);

            char myGrade = 'A'; // chars MUST use single goose eyes

            /* type casting is assigning the value of one data type to another 
            Implicit casting happens automatically (smaller to larger size)
            char > int > long > float > double 
            Explcit casting has to happen manually
            double > float > long > int > char
            */
            
            int myInt = 9; 
            double myDouble2 = myInt; // this is an example of implicit casting 
            Console.WriteLine(myDouble2);

            double myDouble3 = 9.78;
            myInt = (int) myDouble3;
            Console.WriteLine(myDouble3);
            Console.WriteLine(myInt);

            //Data types can also be converted 
            int myInt2 = 10;
            double myDouble4 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToInt32(myDouble4));
            Console.WriteLine(Convert.ToString(myBool2));
            //Type conversion often necessary for user input 
            





        }
    }
}
