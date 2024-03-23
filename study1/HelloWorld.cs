using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.Write("줄 바꿈 없음");
            Console.WriteLine("줄 바꿈 있음");
            Console.WriteLine("줄\n바꿈");

            Console.WriteLine("{0}", "Hello C#");

            int number;
            number = 7;
            Console.WriteLine(number);

            Console.WriteLine(1234);
            Console.WriteLine(3.14F);
            Console.WriteLine('A');
            Console.WriteLine("HELLO");
        }
    }
}