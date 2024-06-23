namespace HomeworkGB2
{
    public interface IBit
    {
        bool GetBitByPosition(byte index);
        void SetBitByPosition(byte index, bool value);
    }
    internal class Bits : IBit
    {
        public long Value { get; private set; }
        public int Size { get; private set; }
        public Bits(byte value)
        {
            Value = value;
            Size = sizeof(byte);
        }
        public Bits(int value)
        {
            Value = value;
            Size = sizeof(int);
        }
        public Bits(long value)
        {
            Value = value;
            Size = sizeof(long);
        }
        public bool this[byte index]
        {
            get => GetBitByPosition(index);
            set => SetBitByPosition(index, value);
        }
        public bool GetBitByPosition(byte index)
        {
            return (Value & (1 << index)) != 0;
        }
        public void SetBitByPosition(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public static implicit operator long(Bits bits) => bits.Value;
        public static explicit operator Bits(long value) => new(value);

        public static implicit operator int(Bits bits) => (int)bits.Value;
        public static explicit operator Bits(int value) => new(value);

        public static implicit operator byte(Bits bits) => (byte)bits.Value;
        public static explicit operator Bits(byte value) => new(value);
    }
}
