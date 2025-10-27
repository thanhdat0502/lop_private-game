namespace Bai_1_buoi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c || a + c > b || b + c > a)
            {
                if (a == b && a == c && b == c) { Console.WriteLine("Tam giac deu"); }
                else
                {
                    if (a == b || b == c || a == c) Console.WriteLine("Tam giac can");
                    else Console.WriteLine("Tam giac thuong");
                }
            }
            else Console.WriteLine("Khong the tao thanh tam giac");
        }
    }
}
