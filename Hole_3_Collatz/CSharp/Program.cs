using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] a)
        {
            int i = 1;
            for(var x = int.Parse(a[0]);x!=1;i++){
                if (x%2==0){
                    x = x / 2;
                }else{
                    x = (x * 3) + 1;
                }
            }
            System.Console.WriteLine($"Length: {i}");
        }
    }
}
