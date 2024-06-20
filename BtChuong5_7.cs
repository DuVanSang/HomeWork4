using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một Dictionary với kiểu dữ liệu cho key là string và value là int
        Dictionary<string, int> studentGrades = new Dictionary<string, int>();

        // Thêm một số cặp key-value vào Dictionary
        studentGrades["Hung"] = 85;
        studentGrades["Baek"] = 90;
        studentGrades["Charlie"] = 78;

        // Sử dụng phương pháp ContainsKey để kiểm tra xem một key có tồn tại trong Dictionary hay không
        string keyToCheck = "Hung";
        if (studentGrades.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Key '{keyToCheck}' exists in the dictionary.");
        }
        else
        {
            Console.WriteLine($"Key '{keyToCheck}' does not exist in the dictionary.");
        }

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một key nhất định một cách an toàn
        int grade;
        if (studentGrades.TryGetValue("Baek", out grade))
        {
            Console.WriteLine($"The grade for 'Hung' is {grade}.");
        }
        else
        {
            Console.WriteLine($"Key 'Hung' does not exist in the dictionary.");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Dictionary và in chúng
        foreach (KeyValuePair<string, int> kvp in studentGrades)
        {
            Console.WriteLine($"Student: {kvp.Key}, Grade: {kvp.Value}");
        }
    }
}
