using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Thêm một vài từ vào từ điển
        dictionary.Add("hello", "xin chào");
        dictionary.Add("goodbye", "tạm biệt");
        dictionary.Add("thank you", "cảm ơn");
        dictionary.Add("smile", "cười");
        dictionary.Add("sad", "buồn");

        while (true)
        {
            Console.WriteLine("\nTừ điển Anh - Việt");
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Tìm nghĩa của từ");
            Console.WriteLine("3. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddWord();
                    break;
                case "2":
                    TranslateWord();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddWord()
    {
        Console.Write("Nhập từ tiếng Anh: ");
        string englishWord = Console.ReadLine().ToLower();
        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine("Từ này đã có trong từ điển.");
        }
        else
        {
            Console.Write("Nhập nghĩa tiếng Việt: ");
            string vietnameseMeaning = Console.ReadLine();
            dictionary.Add(englishWord, vietnameseMeaning);
            Console.WriteLine("Thêm từ thành công.");
        }
    }

    static void TranslateWord()
    {
        Console.Write("Nhập từ tiếng Anh: ");
        string englishWord = Console.ReadLine().ToLower();
        if (dictionary.TryGetValue(englishWord, out string vietnameseMeaning))
        {
            Console.WriteLine($"Nghĩa của '{englishWord}' là: {vietnameseMeaning}");
        }
        else
        {
            Console.WriteLine("Từ này không có trong từ điển.");
        }
    }
}
