public class Person
{
    private string hoTen;
    private int tuoi;
    private string diaChi;

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public int Tuoi
    {
        get { return tuoi; }
        set
        {
            while (value <= 0)
            {
                Console.Write("Tuổi phải > 0. Nhập lại tuổi: ");
                value = int.Parse(Console.ReadLine());
            }
            tuoi = value;
        }
    }

    public string DiaChi
    {
        get { return diaChi; }
        set { diaChi = value; }
    }

    public Person() { }

    
    public Person(string hoTen, int tuoi, string diaChi)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        DiaChi = diaChi;
    }
}

