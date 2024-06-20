using System;
using System.Collections;
using System.Text;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public override string ToString()
    {
        return $"Tên: {Name}, Mô tả: {Description}, Giá: {Price:C}";
    }
}

class BtChuong5_3
{
    static ArrayList productList = new ArrayList();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nQuản lý danh sách sản phẩm");
            Console.WriteLine("1. Thêm sản phẩm mới");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    DisplayProducts();
                    break;
                case "3":
                    SearchProduct();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Nhập tên sản phẩm: ");
        string name = Console.ReadLine();
        Console.Write("Nhập mô tả sản phẩm: ");
        string description = Console.ReadLine();
        double price;
        while (true)
        {
            Console.Write("Nhập giá sản phẩm: ");
            if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá không hợp lệ. Vui lòng nhập lại.");
            }
        }

        productList.Add(new Product(name, description, price));
        Console.WriteLine("Thêm sản phẩm thành công.");
    }

    static void DisplayProducts()
    {
        if (productList.Count == 0)
        {
            Console.WriteLine("Không có sản phẩm nào để hiển thị.");
        }
        else
        {
            Console.WriteLine("Danh sách sản phẩm:");
            foreach (Product product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }

    static void SearchProduct()
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string searchName = Console.ReadLine().ToLower();
        bool found = false;

        foreach (Product product in productList)
        {
            if (product.Name.ToLower().Contains(searchName))
            {
                Console.WriteLine(product);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy sản phẩm nào khớp với tên đã nhập.");
        }
    }
}
