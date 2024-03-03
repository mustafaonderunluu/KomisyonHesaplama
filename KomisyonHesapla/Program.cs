
int satılanmallar = 0;
int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0;

Console.Write("Birinci Ücretini Giriniz = ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci Malın Ücretini Giriniz = ");
s2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Üçüncü Malın Ücretini Giriniz = ");
s3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Dördüncü Malın Ücretini Giriniz = ");
s4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Beşinci Malın Ücretini Giriniz = ");
s5 = Convert.ToInt32(Console.ReadLine());

satılanmallar = s1 + s2 + s3 + s4 + s5;

double komisyon;
if (satılanmallar <= 50)
{
    komisyon = satılanmallar * 1.40;
}
else
{
    komisyon = satılanmallar * 1.90;
}

Console.WriteLine("Toplam Satılan Malların Maliyeti :"+ satılanmallar );
Console.WriteLine("Toplam Komisyon Hesaplaması  : {0} ", komisyon);
