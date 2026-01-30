namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 1: ตรวตสอบเลขบวก/ลบ และคู่/คี่");
            Console.Write("ป้อนตัวเลข: ");
            int value = int.Parse(Console.ReadLine());

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
                if (value % 2 == 0)
                {
                    Console.WriteLine("- และเป็นเลขคู่");
                }
                else
                {
                    Console.WriteLine("- และเป็นเลขคี่");
                }
            }
            else
            {
                Console.WriteLine("- เป็นศูนย์");
            }
        }
    }
}