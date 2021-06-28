using System;

namespace learnC_
{
    public struct DiemXY
    {
        public int x;
        public int y;
    }
    class XL_Diem

    {
       
        public static DiemXY NhapDiemXY()
        {
            DiemXY a;
            Console.Write("Nhap diem x: ");
            a.x = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem y: ");
            a.y = int.Parse(Console.ReadLine());
            return a;
        }
         public static double TinhKC2DiemXY (DiemXY a, DiemXY b)
         {
             double kq;
             kq = Math.Sqrt(Math.Pow((a.x - b.x),2) + Math.Pow((a.y - b.y),2));
             return kq;
         }
    }
}
