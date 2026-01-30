namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ตัวอย่างที่ 2.1: ตรวจสอบเลขคู่หรือเลขคี่");
            int num = 7;
            Console.WriteLine($"ตัวเลข: {num}");

            if (num % 2 == 0)
            {
                Console.WriteLine("เป็นเลขคู่");
            }
            else
            {
                Console.WriteLine("เป็นเลขคี่");
            }
        }
    }
}

