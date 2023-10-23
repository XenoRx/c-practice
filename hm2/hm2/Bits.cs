using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm2
{
    public class Bits
    {
        public readonly byte[] Data;

        public Bits(long value)
        {
            Data = BitConverter.GetBytes(value);
        }

        public Bits(int value)
        {
            Data = BitConverter.GetBytes(value);
        }

        public Bits(byte value)
        {
            Data = new byte[1];
            Data[0] = value;
        }

        public static implicit operator Bits(long value)
        {
            return new Bits(value);
        }

        public static implicit operator Bits(int value)
        {
            return new Bits(value);
        }

        public static implicit operator Bits(byte value)
        {
            return new Bits(value);
        }
    }
}
