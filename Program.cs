namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // VERIABLES and DATATYPES

            byte a = 1;
            sbyte b = 2;
            short c = 3;
            ushort d = 4;
            int e = 5;
            uint f = 6;
            long g = 7;
            ulong h = 8;
            float i = 9.10F;
            double j = 10.11;
            Decimal k = 11.2m;

            char l = 'a';

            bool m = true;

            string n = "yash";

            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}, {j}, {k}, {l}, {m}, {n}");

            // byte
            /* byte = 0 to 255 
             * sbyte  = -128 to 127
             */
            sbyte number1 = sbyte.MinValue;
            sbyte number2 = sbyte.MaxValue;
            Console.WriteLine($"Minimum and Maximum byte values are {number1} and {number2}");


            // Short 
            /* ushort  = 0 to 65535
             * short = 32767 to -32768
             */
            short number3 = short.MaxValue;
            short number4 = short.MinValue;
            Console.WriteLine($"Maximum and Minumum short values are {number3} and {number4}");

            // int 
            /* int  =  2147483647 to -2147483648
             * uint =  to  4294967295
             */
            int number5 = int.MaxValue;
            int number6 = int.MinValue;
            Console.WriteLine($"Maximum and Minumum int values are {number5} and {number6}");

            // long 
            /* long = 9223372036854775807 to-9223372036854775808
             * ulong = 0 to 18446744073709551615
             */
            ulong number7 = ulong.MaxValue;
            ulong number8 = ulong.MinValue;
            Console.WriteLine($"Maximum and Minumum long values are {number7} and {number8}");

            // float 
            /* float =  -3.4028235E+38 to 3.4028235E+38
             */
            float number9 = float.MaxValue;
            float number10 = float.MinValue;
            Console.WriteLine($"Maximum and Minumum float values are {number10} and {number9}");

            // double 
            /* double = 1.7976931348623157E+308 to -1.7976931348623157E+308
             */
            double number11 = double.MaxValue;
            double number12 = double.MinValue;
            Console.WriteLine($"Maximum and minimum values are {number11} and {number12}");

            // decimal
            /* Decimal = 79228162514264337593543950335 to -79228162514264337593543950335
             */
            Decimal number13 = Decimal.MaxValue;
            Decimal number14 = Decimal.MinValue;
            Console.WriteLine($"Maximum and Minimum values are {number13} and {number14}");

            // OPERATORS 

            int someNumber = 20;
            int anotherNumber = 10;

            // BINARY

            //Arithmetic
            Console.WriteLine($" Addition {someNumber + anotherNumber}");
            Console.WriteLine($" Substraction {someNumber - anotherNumber}");
            Console.WriteLine($" Multiplication {someNumber * anotherNumber}");
            Console.WriteLine($" Division {someNumber / anotherNumber}");
            Console.WriteLine($" Remainder {someNumber % anotherNumber}");

            //Relationl
            Console.WriteLine($" Equals to {someNumber == anotherNumber}");
            Console.WriteLine($" Not equals to  {someNumber != anotherNumber}");
            Console.WriteLine($" Smaller then  {someNumber < anotherNumber}");
            Console.WriteLine($" Greater then {someNumber > anotherNumber}");
            Console.WriteLine($" Smaller then or equal to {someNumber <= anotherNumber}");
            Console.WriteLine($" Greater then equal to {someNumber >= anotherNumber}");

            //Assignment 
            Console.WriteLine($" Assignment ' = ' ");
            Console.WriteLine($" Assignmet ' += ' {someNumber += anotherNumber}");
            Console.WriteLine($" Assignmet ' -= ' {someNumber -= anotherNumber}");
            Console.WriteLine($" Assignmet ' *= ' {someNumber *= anotherNumber}");
            Console.WriteLine($" Assignmet ' /= ' {someNumber /= anotherNumber}");
            Console.WriteLine($" Assignmet ' %= ' {someNumber %= anotherNumber}");


            // Logical 

            bool value1 = false;
            bool value2 = true;

            Console.WriteLine($" AND ' && ' both value should be true {value1 && value2}");
            Console.WriteLine($" OR ' || ' any one of the value should be true {value1 || value2}");
            Console.WriteLine($" NOT ' ! 'it makes true to false or false to true {!true}");

            // bitwise

            int value3 = 10;
            int value4 = 11;

            Console.WriteLine($" AND ' & '  {value3 & value4}");
            Console.WriteLine($" OR ' & ' {value3 | value4}");
            Console.WriteLine($" left shift ' << '  {value3 << value4}");
            Console.WriteLine($" Right shift ' & '  {value3 >> value4}");
            Console.WriteLine($" Bitwise Complement Operator ' ~ ' {~value4}");
            Console.WriteLine($" XOR ' ^ '  {value3 ^ value4}");

            //UNARY 

            // Post

            int value5 = 1;
            int value6 = 2;
            // Post increment
            Console.WriteLine($" First uses and then increments {value5++}");
            // Post decrement
            Console.WriteLine($" First uses and then decrement {value6--}");

            // Pre

            // Pre increment
            Console.WriteLine($" Increments uses and then uses {++value5}");
            // Pre decrement
            Console.WriteLine($" Decrememnt uses and then uses {--value5}");


            // TERNARY

            bool answer = (value5 < value6) ? true : false;
            Console.WriteLine(answer);

            // Conditions statements

            int value7 = 1;
            int value8 = 2;

            // If

            if (value7 == 1)
            {
                Console.WriteLine("Value is one");
            }

            // if else

            if (value8 == 1)
            {
                Console.WriteLine("Value is one");
            }
            else
            {
                Console.WriteLine("Value is two");
            }

            // if else if else

            if (value7 == 1)
            {
                Console.WriteLine("Value is one");
            }
            else if (value8 == 2)
            {
                Console.WriteLine("Value is two");
            }
            else
            {
                Console.WriteLine("Value is Higher then 1 and 2");
            }

            char z = 'z';
            switch (z)
            {
                case 'a': Console.WriteLine("Character is a"); break;

                case 'z': Console.WriteLine("Character is z"); break;

                    // default: Console.WriteLine("None of the above characters");
            }

            // For loop
            for (int i1 = 0; i1 < 5; i1++)
            {
                Console.WriteLine("Hello World");
            }


            // While loop 
            int x = 4;
            while (x > 0)
            {
                Console.WriteLine("Hello World");
                x--;
            }

            // Do while
            int w = 3;
            do { Console.WriteLine("Hello World"); w--; }
            while (w > 0);


        }
    }
}

