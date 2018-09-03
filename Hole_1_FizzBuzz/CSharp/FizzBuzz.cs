using System;
class Program
{
static void Main(string[] a)
{
for(var i=0;i<101;++i){
if(i%3==0){
Console.Write("Fizz");
}
if(i%5==0){
Console.Write("Buzz");
}
if(i%3!=0&&i%5!=0){
Console.Write(i);
}
Console.WriteLine();
}
}
}
