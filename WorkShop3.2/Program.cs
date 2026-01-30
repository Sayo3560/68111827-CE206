namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบึกหัดที่ 2: คำนวณค่าไฟ");
            Console.Write("ป้อนจำนวนหน่วยไฟฟ้าที่ใช้: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"จำนวนหน่วยที่ใช้: {value} หน่วย");
            if (value <= 150)
            {
                Console.WriteLine($"ต่าไฟฟ้ารวม: {value * 3.00} บาท");
            }
            else if (value <= 400)
            {
                Console.WriteLine($"ต่าไฟฟ้ารวม: {value * 4.00} บาท");
            }
            else if (value > 400)
            {
                Console.WriteLine($"ต่าไฟฟ้ารวม: {value * 5.00}  บาท");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}