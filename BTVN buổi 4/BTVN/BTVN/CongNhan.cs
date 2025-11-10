public class CongNhan : Person
{
    private string maCongNhan;
    private ChucVu chucVu;

    public string MaCongNhan
    {
        get { return maCongNhan; }
        set { maCongNhan = value; }
    }

    public ChucVu ChucVu
    {
        get { return chucVu; }
        set { chucVu = value; }
    }

    public CongNhan() : base() { }

    public CongNhan(string ma, string hoTen, int tuoi, string diaChi, ChucVu chucVu)
        : base(hoTen, tuoi, diaChi)
    {
        MaCongNhan = ma;
        ChucVu = chucVu;
    }

    public double TinhLuong()
    {
        double heSo = 1.0;
        switch (ChucVu)
        {
            case ChucVu.TruongNhom: heSo = 3.0; break;
            case ChucVu.PhoNhom: heSo = 2.5; break;
            case ChucVu.CongNhanBac3: heSo = 2.0; break;
            case ChucVu.CongNhanBac2: heSo = 1.5; break;
            case ChucVu.CongNhanBac1: heSo = 1.2; break;
            default: heSo = 1.0; break;
        }
        return heSo * 8000000;
    }

    public void HienThi()
    {
        Console.WriteLine($"{MaCongNhan,-10} {HoTen,-20} {Tuoi,-5} {DiaChi,-20} {ChucVu,-20} {TinhLuong(),-10:N0} VND");
    }
}