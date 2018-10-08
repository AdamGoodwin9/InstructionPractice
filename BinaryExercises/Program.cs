using System;

namespace BinaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //float f = 16;
            //PrintBinary(BitConverter.SingleToInt32Bits(f));
            //Console.WriteLine(BitConverter.IsLittleEndian);
            Console.WriteLine(Run(0x_04_00_1E_03));
            Console.ReadKey();
        }

        static byte Run(uint data)
        {
            byte GetByte(uint num, int n) => (byte)(((1 << 8) - 1) & (num >> (n * 8)));
            byte instruction = GetByte(data, 3);
            byte op1 = GetByte(data, 1);
            byte op2 = GetByte(data, 0);

            switch (instruction)
            {
                case 1: //add
                    return (byte)(op1 + op2);
                case 2: //sub
                    return (byte)(op1 - op2);
                case 3: //mul
                    return (byte)(op1 * op2);
                case 4: //div
                    return (byte)(op1 / op2);
                case 5: //mod
                    return (byte)(op1 % op2);
                default:
                    Console.WriteLine("Invalid op");
                    break;
            }
            return 0;
        }

        static int FindNearestPowerOfTwo(int num)
        {
            int temp = 1;

            while (temp < num)
            {
                temp <<= 1;
            }
            return temp;
        }

        static int MultiplyByPowOf2(int num, int exp) => num << exp;

        static int IntDivideByPowOf2(int num, int exp) => num >> exp;

        static int FlipNthBit(int num, int n) => num ^ (1 << n);

        static int GetMBitsAtN(int num, int m, int n) => ((1 << m) - 1) & (num >> n);

        static int ModByPowerOf2(int num, int exp) => ((1 << exp) - 1) & num;

        static void ShiftToNegative()
        {
            long thing = long.MaxValue;
            Console.WriteLine(thing << 1 | 1);
        }

        static void PrintBinary(int num)
        {
            Console.WriteLine(Convert.ToString(num, 2));
        }
    }
}
