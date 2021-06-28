using System;

namespace learnC_
{
    class XuLySoNguyen
    {
        public static void TimNgayKT (int ngay, int thang, int nam, ref int ngayKT, ref int thangKT, ref int namKT)
        {
            int ngaytrongthang = SoNgay (thang, nam);
            ngayKT = ngay + 1;
            thangKT = thang;
            namKT = nam;
            if (ngayKT > ngaytrongthang)
            {
                ngayKT = 1;
                thangKT = thangKT + 1;
            }
            if (thangKT > 12)
            {
                thangKT = 1;
                namKT = nam + 1;
            }
        }
        public static int SoNgay (int a, int b)
        {
            int kq = 31;
            if (a == 2)
            {
                if ((b % 4 == 0 && b % 4 != 0) || (b % 400 == 0))
                {
                    kq = 29;
                }
                else
                {
                    kq = 28;
                }
            }
            if (a == 4 || a == 6 || a == 9 || a == 11)
            {
                kq = 30;
            }
            return kq;
        }
        public static int TimMax (int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;  
            }
        }
        public static bool KTsoNguyento (int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i <= x / 2; i++)
            { 
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int TinhGiaiThua (int x)
        {
            int kq = 1;
            for (int i = 2; i <= x; i++) //int i =2 la de cho nhanh bỏ giai thua 1, nhung neu nhap la 1 se bao loi
            {
                kq = kq * i;
            }
            return kq;
        }
        public static int TinhTongGiaiThua (int x)
        {
            int kq = 1;
            for  (int i = 2; i <= x; i++) //bai cua thay tren clip bi sai neu de tinh giai thua 1
            {
                kq = kq + TinhGiaiThua(i);
            }
            return kq;
        }
        public static void LietkeSoNgto (int x)
        {
            if (x <= 1)
            {
                Console.WriteLine($"So {x} khong co so nguyen to");
            }
            for (int i = 2; i <= x; i++)
            {
                if (KTsoNguyento(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
