internal class Program
{
    static void Main(string[] args)
    {
        List<CongNhan> danhSach = new List<CongNhan>();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Thêm công nhân");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Sắp xếp theo tên và lương");
            Console.WriteLine("4. Tìm công nhân theo mã");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();
            Console.WriteLine();

            switch (chon)
            {
                case "1":
                    ThemCongNhan(danhSach);
                    break;
                case "2":
                    HienThiDanhSach(danhSach);
                    break;
                case "3":
                    SapXepDanhSach(danhSach);
                    break;
                case "4":
                    TimTheoMa(danhSach);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }

    static void ThemCongNhan(List<CongNhan> ds)
    {
        Console.Write("Nhập mã công nhân: ");
        string ma = Console.ReadLine();

        if (ds.Any(cn => cn.MaCongNhan == ma))
        {
            Console.WriteLine("❌ Mã công nhân đã tồn tại!");
            return;
        }

        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();

        Console.Write("Nhập tuổi: ");
        int tuoi;
        while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi <= 0)
        {
            Console.Write("Tuổi không hợp lệ, nhập lại: ");
        }

        Console.Write("Nhập địa chỉ: ");
        string diaChi = Console.ReadLine();

        Console.WriteLine("Chọn chức vụ (nhập số):");
        foreach (var cv in Enum.GetValues(typeof(ChucVu)))
        {
            Console.WriteLine($"{(int)cv}. {cv}");
        }

        int chonCV;
        while (!int.TryParse(Console.ReadLine(), out chonCV) || chonCV < 0 || chonCV > Enum.GetValues(typeof(ChucVu)).Length - 1)
        {
            Console.Write("Chức vụ không hợp lệ, nhập lại: ");
        }

        CongNhan cn = new CongNhan(ma, hoTen, tuoi, diaChi, (ChucVu)chonCV);
        ds.Add(cn);
        Console.WriteLine("Thêm công nhân thành công!");
    }

    static void HienThiDanhSach(List<CongNhan> ds)
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách trống!");
            return;
        }

        Console.WriteLine($"{"Mã",-10} {"Họ Tên",-20} {"Tuổi",-5} {"Địa chỉ",-20} {"Chức vụ",-20} {"Lương",-15}");
        Console.WriteLine(new string('-', 90));
        foreach (var cn in ds)
            cn.HienThi();
    }

    static void SapXepDanhSach(List<CongNhan> ds)
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách trống!");
            return;
        }

        var sorted = ds.OrderBy(cn => cn.HoTen).ThenBy(cn => cn.TinhLuong()).ToList();
        Console.WriteLine("Danh sách sau khi sắp xếp:");
        HienThiDanhSach(sorted);
    }

    static void TimTheoMa(List<CongNhan> ds)
    {
        Console.Write("Nhập mã công nhân cần tìm: ");
        string ma = Console.ReadLine();

        var cn = ds.FirstOrDefault(c => c.MaCongNhan == ma);
        if (cn != null)
        {
            Console.WriteLine($"{"Mã",-10} {"Họ Tên",-20} {"Tuổi",-5} {"Địa chỉ",-20} {"Chức vụ",-20} {"Lương",-15}");
            Console.WriteLine(new string('-', 90));
            cn.HienThi();
        }
        else
        {
            Console.WriteLine("Không tìm thấy công nhân có mã này!");
        }
    }
}
}