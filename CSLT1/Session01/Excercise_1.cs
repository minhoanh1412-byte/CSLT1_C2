namespace CSLT1.session01
{
    internal class Excercise_1
    {
        public static void Main(string[] args)
        {
            //1. AD/Sum two number
            Console.WriteLine("1. ADD / SUM TWO NUMBERS");
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine($"Before x={x}, y={y}");
            Console.WriteLine(sum);
            //2. SWAP VALUES 
            Console.WriteLine("2. SWAP VALUES");
            int temp = x;
            x = y; ;
            y = temp;
            Console.WriteLine($"After x={x}, y={y}");
            //3. Nhan hai so thuc
            Console.WriteLine("3. Multiply two Floating");
            float a = 3.5f;
            float b = 3.7f;
            float c = a * b;
            Console.WriteLine($"{a}*{b}={c}");
            //4. to convert feet to metter
            float feet = 5.7f;
            float metter = 0.3048f * feet;
            Console.WriteLine($"feet = {feet} is {metter} metter" );
            //5
            float cels = 27f;
            float fah = cels * 1.8f + 32;
            Console.WriteLine($"cels = {cels} is {fah} fah");
            //6
            Console.WriteLine($"size double data type is {sizeof(double)}");
            Console.WriteLine($"size int data is {sizeof(int)}");
            //7 
            Console.WriteLine("Enter a character:");
            int g = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {g}");
            //8 dt hinh tron
            float r = 6;
            float area = 3.14f * r;
            Console.WriteLine($"Area of circle is {area} if r={r}");
            //9 dt hinh vuong
            float canh = 10;
            float area2 = canh * canh;
            Console.WriteLine($"Area of square is {area2} if canh={canh}");
            //10 convert day, year, week
            float day = 10;
            float year = day / 365;
            float week = day / 7;
            Console.WriteLine($"If day = {day}, year = {year}, week = {week}");
        }
    }
}
