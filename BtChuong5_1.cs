using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    public double Score { get; set; }

    public Student(string name, string @class, double score)
    {
        Name = name;
        Class = @class;
        Score = score;
    }

    public override string ToString()
    {
        return $"Tên: {Name}, Lớp: {Class}, Điểm: {Score}";
    }
}

class BtChuong5_1
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            DisplayMenu();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayStudents();
                    break;
                case "3":
                    CalculateTotalScore();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nQuản lý sinh viên");
        Console.WriteLine("1. Thêm sinh viên mới");
        Console.WriteLine("2. Hiển thị danh sách sinh viên");
        Console.WriteLine("3. Tính tổng điểm của tất cả sinh viên");
        Console.WriteLine("4. Thoát");
        Console.Write("Chọn một tùy chọn: ");
    }

    static void AddStudent()
    {
        Console.Write("Nhập tên sinh viên: ");
        string name = Console.ReadLine();
        Console.Write("Nhập lớp của sinh viên: ");
        string @class = Console.ReadLine();

        double score;
        while (true)
        {
            Console.Write("Nhập điểm của sinh viên (1-10): ");
            if (double.TryParse(Console.ReadLine(), out score) && score >= 1 && score <= 10)
            {
                break;
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập điểm từ 1 đến 10.");
            }
        }

        students.Add(new Student(name, @class, score));
        Console.WriteLine("Thêm sinh viên thành công.");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Không có sinh viên nào để hiển thị.");
        }
        else
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    static void CalculateTotalScore()
    {
        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Score;
        }
        Console.WriteLine($"Tổng điểm của tất cả sinh viên: {totalScore}");
    }
}