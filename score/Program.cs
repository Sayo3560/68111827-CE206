namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ตัวอย่างที่ 3.1: ระดับคะแนน");
            int points = 75;
            Console.WriteLine($"คะแนน: {points}");

            if (points >= 80)
            {
                Console.WriteLine("ระดับ: ดีมาก (Excellent)");
            }
            else if (points >= 70)
            {
                Console.WriteLine("ระดับ: ดี (Good)");
            }
            else if (points >= 65)
            {
                Console.WriteLine("ระดับ: ปานกลาง (Fair)");
            }
            else if (points >= 60)
            {
                Console.WriteLine("ระดับ: พอใช้ (Pass)");
            }
            else
            {
                Console.WriteLine("ระดับ: ไม่ผ่าน (Fail)");
            }
        }
    }
}