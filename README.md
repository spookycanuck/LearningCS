# LearningCS
C# tutorial, notes, etc.

**The documentation is a work in progress**. Notes will live in the individual files as comments. Important finds & explanations will be transcribed to the README.

### Program.cs
Learned that I can't use the compiler to run individual files like a Python interpreter can. The compiler in C# will try to compile the whole project. Thus, you can only have one "main" function. After a few hours of troubleshooting (and some help from my peers), I reorganized the file structure so that the `Main` function called a class of the name `Chapter`. This class is defined in the other files as a `public partial class`. I found this was the easiest way *for this project* to keep everything organized topically. More info on partial classes can be found in the reference docs, [here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods).

Refer to the `fileTemplate.cs` file for info on how to add new functions/files to the class.
