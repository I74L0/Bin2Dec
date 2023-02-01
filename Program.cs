using System;

Console.WriteLine("Please, enter up to 8 binary digits (0 or 1):");
var bin = Console.ReadLine();
if (bin != null && bin.Length != 0 && bin.Length < 9)
{
    for (int i = 0; i < bin.Length; i++)
    {
        if (!(bin[i] == '1' || bin[i] == '0'))
        {
            Console.WriteLine("Please, just type 0's or 1's");
            return;
        }
    }
    Console.WriteLine($"Binary: {bin}");
    Console.WriteLine("Decimal: " + Convert.ToInt32(bin, 2).ToString());
}
else
{
    Console.WriteLine("Please, enter between 0 and 8 digits");
}