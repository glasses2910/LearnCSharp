using System;

namespace learnC_
{
    public struct DaGiac
    {
        public DiemXY[] dsDinh;
    }
    class XL_DaGiac
    {
       public static DaGiac NhapDaGiac()
       {
          DaGiac dg;
          Console.Write("Nhap so dinh da giac: ");
          int N = int.Parse(Console.ReadLine());
          dg.dsDinh = new DiemXY[N];
          for(int i = 0; i < N; i++)
          {
              Console.Write($"Nhap dinh {i + 1}: ");
              dg.dsDinh[i] = XL_Diem.NhapDiemXY();
          }
          return dg;
       }
       public static double TinhChuVi (DaGiac dg)
       {
            double ChuVi = 0;
            int N = dg.dsDinh.Length;
            for (int i = 0; i < N - 1; i++)
            {
                ChuVi = ChuVi + XL_Diem.TinhKC2DiemXY(dg.dsDinh[i], dg.dsDinh[i + 1]);
            }
            ChuVi = ChuVi + XL_Diem.TinhKC2DiemXY(dg.dsDinh[0], dg.dsDinh[N - 1]);
            return ChuVi;
       }
    }
}
