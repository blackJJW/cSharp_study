using System;

class VariableDemo {
    static void Main() {
        int number1, number2, number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;

        Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);

        int a, b, c;
        a = b = c =10;

        Console.WriteLine("{0}, {1}, {2}", a, b, c);

        const int MAX = 100;
        Console.WriteLine(MAX);
        
        int number = 3;
        string result = "abc";
        Console.WriteLine($"{number}  ${result}");

        string msg = string.Format("{0}, {1}", number, number2);
        Console.WriteLine(msg);

        long l = long.MaxValue;
        Console.WriteLine($"l의 값 : {l}");
        int i = (int)l;
        Console.WriteLine($"i의 값 : {i}");
    }
}