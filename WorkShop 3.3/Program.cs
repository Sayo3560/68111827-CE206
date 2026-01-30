namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบึกหัดที่ 3: ระบบตรวยสอบสิทธิ๋เลือกตั้ง");
            Console.Write("ป้อนอายุของคุณ: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("สัญชาติ (ไทย/อื่นๆ): ");
            string Country = Console.ReadLine();
            if (age >= 18)
            {
                if (Country == "ไทย")
                {
                    Console.WriteLine("คุณมีสิทธิ์เลือกตั้ง");
                }
                else
                {
                    Console.WriteLine("คุณไม่มีมีสิทธิ์เลือกตั้ง");
                    Console.WriteLine(" ");
                    Console.WriteLine("เหตุผล: ไม่ใช่สัญชาติไทย");
                }
            }
            else
            {
                Console.WriteLine("ไม่มีคูณมีสิทธิ์เลือกตั้ง");
                Console.WriteLine(" ");
                Console.WriteLine("เหตุผล: อายุต่ำกว่า 18 ปี");
            }
        }
    }
}