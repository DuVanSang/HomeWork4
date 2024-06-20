using System;
using System.Text;

class BtChuong5_4
{
    // Hàm generic để tìm giá trị lớn nhất giữa hai giá trị
    static T Max<T>(T value1, T value2) where T : IComparable<T>
    {
        return value1.CompareTo(value2) > 0 ? value1 : value2;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nChọn kiểu dữ liệu để nhập:");
            Console.WriteLine("1. Số nguyên");
            Console.WriteLine("2. Số thực");
            Console.WriteLine("3. Chuỗi");
            Console.WriteLine("4. Ngày tháng");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CompareIntegers();
                    break;
                case "2":
                    CompareDoubles();
                    break;
                case "3":
                    CompareStrings();
                    break;
                case "4":
                    CompareDates();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void CompareIntegers()
    {
        Console.Write("Nhập số nguyên thứ nhất: ");
        int int1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số nguyên thứ hai: ");
        int int2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Max giữa {int1} và {int2} là: {Max(int1, int2)}");
    }

    static void CompareDoubles()
    {
        Console.Write("Nhập số thực thứ nhất: ");
        double double1 = double.Parse(Console.ReadLine());
        Console.Write("Nhập số thực thứ hai: ");
        double double2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Max giữa {double1} và {double2} là: {Max(double1, double2)}");
    }

    static void CompareStrings()
    {
        Console.Write("Nhập chuỗi thứ nhất: ");
        string string1 = Console.ReadLine();
        Console.Write("Nhập chuỗi thứ hai: ");
        string string2 = Console.ReadLine();
        Console.WriteLine($"Max giữa \"{string1}\" và \"{string2}\" là: \"{Max(string1, string2)}\"");
    }

    static void CompareDates()
    {
        Console.Write("Nhập ngày tháng thứ nhất (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.Write("Nhập ngày tháng thứ hai (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Max giữa {date1.ToShortDateString()} và {date2.ToShortDateString()} là: {Max(date1, date2).ToShortDateString()}");
    }
}