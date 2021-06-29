using System;

namespace LaiCongGoc
{
    
    class Program
    {       
       
        static void Main(string[] args)
        {

        float TienLai;
        double laisuat;
        Console.Write("Nhap so tien vay: ");
        double tienvay = int.Parse(Console.ReadLine());
        Console.Write("Nhap lai suat/thang: ");
        laisuat = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thang vay: ");
        int N = int.Pars(Console.ReadLine());
        for (int i = 0; i <= N; i++)
        {
        	TienLai = tienvay * laisuat / 100;
        	tienvay = tienvay + TienLai;
        }
        Console.WriteLine(TienLai);
    }
}
