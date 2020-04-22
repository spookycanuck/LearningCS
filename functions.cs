using System;

// YT link:  https://www.youtube.com/watch?v=oEkjT56I_fk 
// Current progress:  X

namespace LearningCS
{
    public partial class Chapter
    {
      /*
        public partial class "Chapter" is called from program.cs Main function
        in the LearningCS namespace.
        I set up the partial class in order to keep each video in its own file.
        That way, I can comment out the function calls (which reaches back to the
        void function in this file) when I'm not using them.
        My hope is to use this as an organization tactic, as well as learning how to
        get files to talk to each other.
      */
        public void functions()
        {
          var color = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("every program will start with this.");
          Console.ForegroundColor = color;
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("this is a fun story.");
          Console.ForegroundColor = color;
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("but it had to end now.");
          Console.ForegroundColor = color;
          Console.ReadLine();

        }
    }
}
