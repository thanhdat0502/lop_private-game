class bBai_4_buoi_2
{
    static void Main()
    {
        Console.Write("Nhap chuoi ban dau: ");
        string chuoiBanDau = Console.ReadLine();
        Console.Write("Nhap chuoi can tim: ");
        string chuoiCanTim = Console.ReadLine();
        Console.Write("Nhap chuoi can chen: ");
        string chuoiCanChen = Console.ReadLine();
        int vt = chuoiBanDau.IndexOf(chuoiCanTim);
        if (vt != -1)
        {
            string kq = chuoiBanDau.Insert(vt, chuoiCanChen + " ");
            Console.WriteLine("Ket qua: " + kq);
        }
        else
        {
            Console.WriteLine("Khong the ghep tu – doan khong ton tai!");
        }
    }
}

