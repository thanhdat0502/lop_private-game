//BÀI TẬP: Class Book dùng get/set
//Yêu cầu:

//Tạo class Book với:

//Thuộc tính private: Title(string), Price(double)

//Property get và set:

//Title không được để trống → nếu trống, gán "Unknown"

//Price ≥ 0 → nếu <0, gán 0

//Constructor có tham số title và price

//Method Display() in thông tin sách

//Trong Main(): tạo 2 object Book → in ra thông tin
using System;
class Book
{
    private string Title {  get; set; }
    private double Price { get; set; }
    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }
    public void Display()
    {
        Console.WriteLine("Ten sach la: " + Title);
        Console.WriteLine("Gia thanh: " + Price);
    }
}
class Program
{
    static void Main ( string[] args)
    {
        Book b1 = new Book("Truyen doraemon", 25.5);
        Book b2 = new Book("Sach code AI", 30);
        b1.Display();
        Console.WriteLine();
        b2.Display();
    }
} 
