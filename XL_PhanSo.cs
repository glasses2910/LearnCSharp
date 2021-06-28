using System;

namespace learnC_
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }
    class XL_PhanSo

    {
        public static PhanSo NhapPhanSo()
        {
            PhanSo kq;
            Console.Write("Nhap tu so: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }
        public static PhanSo TinhTongPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
        public static string XuatPhanSo (PhanSo a)
        {
            return $"{a.TuSo}/{a.MauSo}";
        }
    }
}
