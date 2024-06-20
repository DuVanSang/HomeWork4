using System;
using System.Collections.Generic;
using System.Text;

public class MyStack<T>
{
    private List<T> elements = new List<T>();

    // Phương thức Push để thêm phần tử vào ngăn xếp
    public void Push(T item)
    {
        elements.Add(item);
    }

    // Phương thức Pop để loại bỏ và trả về phần tử trên cùng của ngăn xếp
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp rỗng.");
        }

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    // Phương thức Peek để xem phần tử trên cùng của ngăn xếp mà không loại bỏ nó
    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Ngăn xếp rỗng.");
        }

        return elements[elements.Count - 1];
    }

    // Phương thức Count để lấy số lượng phần tử trong ngăn xếp
    public int Count()
    {
        return elements.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nChọn kiểu dữ liệu để tạo ngăn xếp:");
            Console.WriteLine("1. Số nguyên");
            Console.WriteLine("2. Số thực");
            Console.WriteLine("3. Chuỗi");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    HandleStack<int>();
                    break;
                case "2":
                    HandleStack<double>();
                    break;
                case "3":
                    HandleStack<string>();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void HandleStack<T>()
    {
        MyStack<T> stack = new MyStack<T>();
        while (true)
        {
            Console.WriteLine("\nChọn thao tác trên ngăn xếp:");
            Console.WriteLine("1. Thêm phần tử (Push)");
            Console.WriteLine("2. Loại bỏ phần tử (Pop)");
            Console.WriteLine("3. Xem phần tử trên cùng (Peek)");
            Console.WriteLine("4. Xem số lượng phần tử (Count)");
            Console.WriteLine("5. Trở lại menu chính");
            Console.Write("Chọn một tùy chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Nhập phần tử muốn thêm: ");
                    T item = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    stack.Push(item);
                    Console.WriteLine("Đã thêm phần tử.");
                    break;
                case "2":
                    try
                    {
                        T removedItem = stack.Pop();
                        Console.WriteLine($"Đã loại bỏ phần tử: {removedItem}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        T topItem = stack.Peek();
                        Console.WriteLine($"Phần tử trên cùng là: {topItem}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "4":
                    Console.WriteLine($"Số lượng phần tử trong ngăn xếp: {stack.Count()}");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
}