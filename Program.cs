using System;

// YT link:  https://www.youtube.com/watch?v=wwnDtE6Z-ic&feature=youtu.be
// Current progress:  25:00
namespace LearningCS
{
    class Program
    {
        // In C#, comments are with "//"
        /*
        This is a multiline comment.
        */
        // Comments are just text which will not be taken as an instruction, thus will be skipped.
        // Running with VS menu will put application in debug mode.
        // Running with ctrl + F5 will put it in release mode.
        static void Main(string[] args)
        {
            //int is a type for whole numbers
            //integers can be positive, negative, or zero
            int number = 1;
            int number2 = -1;
            int number3 = 0;

            //float is a type for decimals.
            //the default literal is double, so we need to add an 'f' to the end of the declaration to specify that it is a float
            //faster to compile - 32 bit
            float number4 = 1;
            float number5 = 2.5f;

            //double precision compared:
            //slower than float - 64 bit
            double number6 = 2.5;

            //decimal is explicitly used for money and scientific calulations
            //(decimal) is casting from double to decimal.
            decimal money1 = (decimal)1000000000.15m;

            //string used to store text
            string myName = "Eric";

            //char is used to store a single character
            char firstletter = 'K';

            //for binary types (logical true or false) use boolean
            bool isItFristLesson = true;

            //var = variable intialization where console will try to guess variable type
            //var should be used preferably most of the time - although this is a controversial topic
                //although to understand what a function returns it might be better to explicitly define a variable type
            var variableDone = "variables done";
            var timeNow = 10;

            Console.WriteLine("Hello World!");

            int sum = 1 + 5; //6
            int sum2 = sum + sum; //12
            sum2 = sum2 * 2; //24
            var sumMoreFloat = sum2 + 2.0f;
            var sumMoreDecimal = (decimal)sumMoreFloat + (decimal)1.000001;
            Console.WriteLine(sumMoreDecimal);

            var greetings = "hello world!";
            var fullGreeting = myName + ", " + greetings;
            Console.WriteLine(fullGreeting);



        }
    }
}
