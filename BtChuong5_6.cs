using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Tạo một Hashtable
        Hashtable hashtable = new Hashtable();

        // Thêm một số cặp key-giá trị vào Hashtable
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add(3, "Three");
        hashtable.Add("Four", 4);
        hashtable.Add("Five", 5.0);
        hashtable.Add(6, true);

        // Sử dụng ContainsKey để kiểm tra xem một key có tồn tại trong Hashtable hay không
        Console.WriteLine("ContainsKey 2: " + hashtable.ContainsKey(2)); // True
        Console.WriteLine("ContainsKey 10: " + hashtable.ContainsKey(10)); // False

        // Sử dụng ContainsValue để kiểm tra xem một giá trị nhất định có tồn tại trong Hashtable hay không
        Console.WriteLine("ContainsValue \"Three\": " + hashtable.ContainsValue("Three")); // True
        Console.WriteLine("ContainsValue false: " + hashtable.ContainsValue(false)); // False

        // Sử dụng chỉ mục (dấu ngoặc vuông) để truy xuất giá trị được liên kết với một khóa nhất định
        Console.WriteLine("Value associated with key 1: " + hashtable[1]); // One
        Console.WriteLine("Value associated with key \"Four\": " + hashtable["Four"]); // 4

        // Sử dụng vòng lặp foreach để lặp lại các key và giá trị của Hashtable và in chúng
        Console.WriteLine("\nKeys in Hashtable:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues in Hashtable:");
        foreach (var value in hashtable.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\nKey-Value pairs in Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}
