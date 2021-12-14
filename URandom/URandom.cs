using System;

namespace UnsignedRandom
{
    public class URandom
    {
        private readonly Random random;

        public URandom()
        {
            random = new Random();
        }
        public URandom(int Seed)
        {
            random = new Random(Seed);
        }

        public unsafe uint Next()
        {
            int a = random.Next();
            uint b = * ( uint * ) &a;
            return b;
        }
        public unsafe uint Next(uint maxValue)
        {
            int max = * ( int * ) &maxValue;
            int a = random.Next(max);
            uint b = * ( uint * ) &a;
            return b;
        }
        public unsafe uint Next(uint minValue, uint maxValue)
        {
            int min, max;
            min = * ( int * ) &minValue;
            max = * ( int * ) &maxValue;
            int a = random.Next(min, max);
            uint b = * ( uint * ) &a;
            return b;
        }

        public override string ToString()
        {
            return random.ToString();
        }
    }
}
