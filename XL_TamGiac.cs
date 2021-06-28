using System;

namespace learnC_
{
    public struct TamGiac
    {
        public DiemXY a;
        public DiemXY b;
        public DiemXY c;
    }
    class XL_TamGiac
    {
        public static TamGiac NhapTamGiac()
        {
            TamGiac ABC;
            Console.WriteLine("Nhap toa do diem A: ");
            ABC.a = XL_Diem.NhapDiemXY();
            Console.WriteLine("Nhap toa do diem B: ");
            ABC.b = XL_Diem.NhapDiemXY();
            Console.WriteLine("Nhap toa do diem C: ");
            ABC.c = XL_Diem.NhapDiemXY();
            return ABC;
        }
       public static double ChuViTamGiac (TamGiac X)
       {
           double kq;
           kq = XL_Diem.TinhKC2DiemXY(X.a, X.b) + XL_Diem.TinhKC2DiemXY(X.b, X.c) + XL_Diem.TinhKC2DiemXY(X.a, X.c);
           return kq;
       }
    }
}
