using System;

class VariableNote
{
    static void Main()
    {
        int i;
        i = 1234;

        Console.WriteLine(i);

        int number = 7;
        Console.WriteLine("{0}", number);

        int number1, number2, number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;

        Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);

        int a, b, c;
        a = b = c = 100;

        Console.WriteLine("{0}, {1}, {2}", a, b, c);

        const int MAX = 100;
        Console.WriteLine("최댓값 : {0}", MAX);
    }
}