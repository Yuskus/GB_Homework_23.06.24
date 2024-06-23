namespace HomeworkGB2
{
    internal class Program
    {
        static void Main()
        {
            byte myByte = 1;
            int myInt = 2;
            long myLong = 3;

            Console.WriteLine("Переменная myByte типа байт после объявления: " + myByte);
            Console.WriteLine("Переменная myInt типа инт после объявления: " + myInt);
            Console.WriteLine("Переменная myLong типа лонг после объявления: " + myLong);

            var bitByte = new Bits((byte)4);
            var bitInt = new Bits((int)5);
            var bitLong = new Bits((long)6);

            Console.WriteLine("Класс Битс (байт) после объявления: " + bitByte.Value);
            Console.WriteLine("Класс Битс (инт) после объявления: " + bitInt.Value);
            Console.WriteLine("Класс Битс (лонг) после объявления: " + bitLong.Value);

            myByte = bitByte;
            myInt = bitInt;
            myLong = bitLong;

            Console.WriteLine("Переменная myByte типа байт после неявного присваивания класса Битс: " + myByte);
            Console.WriteLine("Переменная myInt типа инт после неявного присваивания класса Битс: " + myInt);
            Console.WriteLine("Переменная myLong типа лонг после неявного присваивания класса Битс: " + myLong);

            byte newByte = 7;
            int newInt = 8;
            long newLong = 9;

            Console.WriteLine("Новая переменная newByte типа байт после объявления: " + newByte);
            Console.WriteLine("Новая переменная newInt типа инт после объявления: " + newInt);
            Console.WriteLine("Новая переменная newLong типа лонг после объявления: " + newLong);

            bitByte = (Bits)newByte;
            bitInt = (Bits)newInt;
            bitLong = (Bits)newLong;

            Console.WriteLine("Класс Битс (байт) после явного присваивания переменной newByte типа байт: " + bitByte.Value);
            Console.WriteLine("Класс Битс (инт) после явного присваивания переменной newInt типа инт: " + bitInt.Value);
            Console.WriteLine("Класс Битс (лонг) после явного присваивания переменной newLong типа лонг: " + bitLong.Value);

            Console.ReadKey(true);
        }
    }
}
