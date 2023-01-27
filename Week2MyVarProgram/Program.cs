/*
 * Clark Comstock
 * Week 2 myVar program, designed to work with myVar being 7
 * 1/27/2023
*/
namespace Week2MyVarProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I used shorts to use less memory
            const short myVar = 7;
            short equation1 = 0;
            short equation2 = 0;
            short equation3 = 0;
            short equation4 = 0;
            short equation5 = 0;

            //equations so that myVar never changes it's value
            equation1 = -1 + 4 * myVar;
            equation2 = (35 + 5) % myVar;
            equation3 = 14 + -4 * 6 / 12;
            equation4 = 2 + 12 / 6 * 1 - myVar % 2;
            equation5 = myVar * myVar;

            Console.WriteLine("Expected output if my var is 7:\n");
            Console.WriteLine(equation1);
            Console.WriteLine(equation2);
            Console.WriteLine(equation3);
            Console.WriteLine(equation4);

            if (equation5 < 10)
                Console.WriteLine("\nmyVar is less than 4");
            else
                Console.WriteLine("\nmyVar is greater than 4");
        }
    }
}