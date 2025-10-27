namespace btvn2_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double dt;
            switch (n)
            {
                case 1:
                    Console.Write("Nhap ban kinh = ");
                    double r = double.Parse(Console.ReadLine());
                    dt = 3.14 * r * r;
                    Console.WriteLine("Dien tich hinh tron {0}", dt);
                    break;
                case 2:
                    Console.Write("Nhap chieu dai = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong = ");
                    double b = double.Parse(Console.ReadLine());
                    dt = a * b;
                    Console.WriteLine("Dien tich hinh chu nhat {0}", dt);
                    break;
                case 3:
                    Console.Write("Nhap day = ");
                    double d = double.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu cao = ");
                    double h = double.Parse(Console.ReadLine());
                    dt = 0.5 * d * h;
                    Console.WriteLine("Dien tich hinh chu nhat {0}", dt);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }
        }
    }
}

