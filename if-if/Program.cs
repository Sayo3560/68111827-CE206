namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ตัวอย่างที่ 4.1: ตรวตสอบเลขบวก/ลบ และคู่/คี่");
            int value = 12;
            Console.WriteLine($"ตัวเลข: {value}");

            if (value > 0)
            {
                Console.WriteLine("- เป็นจำนวนบวก");
                if (value % 2 == 0)
                {
                    Console.WriteLine("- และเป็นเลขคู่");
                }
                else
                {
                    Console.WriteLine("- และเป็นเลขคี่");
                }   
            }
            else if (value < 0)
            {
                Console.WriteLine("- เป็นจำนวนลบ");
            }
            else
            {
                Console.WriteLine("- เป็นศูนย์");
            }
        }
    }
}