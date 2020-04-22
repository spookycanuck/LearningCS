using System;

/*
  This file will compile all other C# files in this program. It will
  call them from main and the respective files shall be under the 
  "LearningCS" namespace and "Chapter" public partial class.
  This file is the one that the compiler should see. Comment out lines
  that are not being tested in the terminal.

  See 'fileTemplate.cs' for info on how to add to this Main function.
*/

namespace LearningCS
{
    class program
    {
        static void Main(string[] args)
        {
            Chapter ch = new Chapter();
            ch.variables();
            ch.functions();
        }
    }
}