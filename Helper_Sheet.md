# Helper Sheet

## Hole 1 - Green Bottles

### C# / dotnet core

Create a folder called GreenBottle, open a command promt in that folder and run:

``` console
dotnew new console
```

Copy and paste the following into the 'Program.cs' file.

```C#
using System;
class Program
{
    static void Main(string[] a)
    {
        System.Console.WriteLine(@"Ten green bottles standing on the wall");
        System.Console.WriteLine("Ten green bottles standing on the wall");
        System.Console.WriteLine("And if one green bottle should accidentally fall,");
        System.Console.WriteLine("There'll be nine green bottles standing on the wall.");
    }
}
```

Use

``` console
dotnet run
```

to run it. This should print out the rhyme.

Now can you make it any smaller? Those first two lines look quite similar...

## Hole 2 - FizzBuzz

Create a new folder called FizzBuzz and create a project with the following command:

```Console
dotnet new console
```

Replace the text in program.cs with:

```CSharp
using System;
class Program
{
    static void Main(string[] a)
    {
        for (var i = 0; i < 101; ++i)
        {
            if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            if (i % 3 != 0 && i % 5 != 0)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
```

## Hole 3 - Collatz Sequence
