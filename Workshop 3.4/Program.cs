namespace cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("แบบฝึกหัดที่ 4: เมนูเครื่องดื่ม");
            Console.WriteLine(" ");
            Console.WriteLine("=== เมนูเครื่องดื่ม ===");
            Console.WriteLine("1. กาแฟ (Coffee) - 45 บาท");
            Console.WriteLine("2. ชา (Tra) - 35 บาท");
            Console.WriteLine("3. นม (Milk) - 30 บาท");
            Console.WriteLine("4. น้ำส้ม (Orange Juice) - 40 บาท");
            Console.WriteLine("5. น้ำเปล่า (Water) - 10 บาท");
            Console.WriteLine(" ");
            Console.Write("เลือกเครื่องดื่ม (1-5): ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch (menu)
            {
                case 1:
                    Console.WriteLine("คุณเลือก: กาแฟ (Coffee)");
                    Console.WriteLine("ราคา: 45 บาท");
                    break;
                case 2:
                    Console.WriteLine("คุณเลือก: ชา (Tra)");
                    Console.WriteLine("ราคา: 35 บาท");
                    break;
                case 3:
                    Console.WriteLine("คุณเลือก: นม (Milk)");
                    Console.WriteLine("ราคา: 30 บาท");
                    break;
                case 4:
                    Console.WriteLine("คุณเลือก: น้ำส้ม (Orange Juice)");
                    Console.WriteLine("ราคา: 40 บาท");
                    break;
                case 5:
                    Console.WriteLine("คุณเลือก: น้ำเปล่า (Water");
                    Console.WriteLine("ราคา: 10 บาท");
                    break;
                default:
                    Console.WriteLine("ไม่มีในเมนู");
                    Console.WriteLine("กรุณาเลือกเมนูที่ถูกต้อง (1-5)");
                    break;
            }
            
        }
    }
}