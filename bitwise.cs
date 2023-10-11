using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitwise AND Truth Table");
        Console.WriteLine("");
        Console.WriteLine("-----------------------");
        Console.WriteLine("|  A  |  B  | A & B |");
        Console.WriteLine("|-----|-----|-------|");

        for (int A = 0; A <= 1; A++)
        {
            for (int B = 0; B <= 1; B++)
            {
                int result = A & B;
                Console.WriteLine($"|  {A}  |  {B}  |   {result}   |");
            }
        }

        Console.WriteLine("-----------------------");
    }
}