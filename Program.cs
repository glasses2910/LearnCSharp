using System;

namespace learnC_
{
    struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }
    class Program
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
        static void Main(string[] args)
        {
            //Nhap phan so
            PhanSo a, b, kq;
            a = NhapPhanSo();
            b = NhapPhanSo();
            kq = TinhTongPhanSo(a, b);
            Console.WriteLine(XuatPhanSo(kq));
            /*
            int [,] A = XL_MaTran.NhapMaTran();
            Console.WriteLine();
            XL_MaTran.XuatMaTran(A);
            Console.WriteLine();
            Console.Write($"Tong cua Ma tran: {XL_MaTran.TongMaTran(A)}");
            Console.WriteLine();
            Console.Write($"Phan tu lon nhat Ma tran: {XL_MaTran.PtuLonNhat(A)}");
            Console.WriteLine();
            Console.Write($"So Phan tu la so Nguyen to: {XL_MaTran.DemNguyenTo(A)}");
            Console.WriteLine();
            Console.Write($"Tong cac Bien: {XL_MaTran.TongCacBien(A)}");
            Console.WriteLine();
            Console.WriteLine($"Nhap dong tinh tong: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write($"Tong dong {k}: {XL_MaTran.TongDongMaTran(A, k)}");
            Console.WriteLine();
            Console.WriteLine($"Nhap cot tinh tich: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write($"Tich cot {c}: {XL_MaTran.TichCotMaTran(A, c)}");
            Console.WriteLine();
            Console.Write($"Ma tran co toan so duong: {XL_MaTran.KTraMaTranDuong(A)}");
            Console.WriteLine();
            Console.WriteLine($"Nhap dong kiem tra tang dang: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Dong {x}: {XL_MaTran.KTraTangDan(A, x)}");
            Console.WriteLine();
            Console.Write($"Ma Tran giam dan: {XL_MaTran.KTraGiamDanMT(A)}");
            Console.WriteLine();
            Console.Write($"So xuat hien nhieu nhat: {XL_MaTran.TimSoLanXuatHien(A)}");
            /* Nhap Ma Tran
            int [,] A; //Khai bao ma tran
            Console.Write("Nhap so dong N: ");
            int N = int.Parse (Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int M = int.Parse (Console.ReadLine());

            A = new int [N,M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"Nhap phan tu cho A[{i}, {j}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Tinh tong Ma tran
            int S = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    S = S + A[i, j];
                }
            }

            // Xuat Ma tran
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }
            /*
            // Nhap mang
            int [] A = XL_Mang.NhapMang();
            int [] B = XL_Mang.NhapMang();
            Console.WriteLine("---------------------");
            XL_Mang.XuatMang(A);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Phan tu lon nhat: {XL_Mang.TimMax(A)}");   
            Console.WriteLine("---------------------");
            Console.WriteLine($"Phan tu nho nhat: {XL_Mang.TimMin(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Tong cac Phan tu am: {XL_Mang.TinhTongPtuAm(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Vi tri trong Mang cua phan tu nho nhat: {XL_Mang.TimViTriPhanTuMin(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine("Liet ke gia tri Chan: ");       
            XL_Mang.LiekeGiatriChan(A);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Gia tri Duong dau tien cua Mang: {XL_Mang.TimGiaTriDuongDauTien(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Gia tri Chan o vi tri cuoi cua Mang: {XL_Mang.TimGiaTriChanCC(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Trung binh Cong cua cac so Ngto trong Mang: {XL_Mang.TinhTBCSoNgTo(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Trung binh Cong cua cac so duong: {XL_Mang.TinhTBCSoDuong(A)}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Trung binh Nhan cua cac so duong: {XL_Mang.TinhTBNSoDuong(A)}");
            Console.WriteLine("---------------------");
            XL_Mang.DemSoLanXuatHien(A);
            Console.WriteLine("---------------------");
            XL_Mang.DemXuatHien2Mang(A, B);
            */
            /*Bai tinh ngay ke tiep theo ngay thang nam dung ham
            int ngay, thang, nam;
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            int ngayKT = 0;
            int thangKT = 0;
            int namKT = 0;
            XuLySoNguyen.TimNgayKT(ngay, thang, nam, ref ngayKT, ref thangKT, ref namKT); // dung ref de tai su dung bien
            Console.WriteLine($"Ngay ke tiep: {ngayKT}/{thangKT}/{namKT}");
            /*int ngayKT;
            int thangKT;
            int namKT;
            XuLySoNguyen.TimNgayKT(ngay, thang, nam, out ngayKT, out thangKT, out namKT); // out ma loi
            Console.WriteLine($"Ngay ke tiep: {ngayKT}/{thangKT}/{namKT}");
            */
        
           
        
            /*int thang, nam, kq; // Bai tinh so ngay trong thang
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            kq = XuLySoNguyen.SoNgay(thang, nam);
            Console.Write(kq);
            /*int N;
            Console.Write("Nhap so N: ");
            N = int.Parse(Console.ReadLine());
            XuLySoNguyen.LietkeSoNgto(N);
            // Giải phương trình ax+b
            /*
            int a, b;
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());
            if(a  == 0)
            {
                if(b == 0)
                {
                Console.WriteLine($"Phuong trinh {a}x + {b} vo so nghiem.");
                }
                else
                {
                Console.WriteLine($"Phuong trinh {a}x + {b} vo nghiem.");   
                }  
            }
            else
            {
                Console.WriteLine($"Phuong trinh {a}x + {b} co nghiem x bang {(-b)/(a*1.0)}");
            }
            */

            /* Giai phuong trinh bac 2
            int a, b, c;
            Console.Write("Nhap so a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            c = int.Parse(Console.ReadLine());
            double d, x, x1, x2;
            d = b * b - 4 * a * c;
            Console.WriteLine($"Delta: {d}");
            if (d < 0)
            {
                Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + c vo nghiem");
            }
            else
            {
                if (d == 0)
                {
                    x = -b / 2.0 * a;
                    Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + c co nghiem kep x = {x}");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / 2.0 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2.0 * a;
                    Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + c co nghiem x1 = {x1} va x2 = {x2}");
                }
            }
            */

            /* Bai 101: Nhap thang nam tinh ra so ngay
            int thang, nam;
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());

            int ngay = 31;

            if (thang == 2)
            {
                if (nam % 4 == 0)
                {
                    ngay = 29;
                }
                else
                {
                    ngay = 28;
                }
            }
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngay = 30;
            }
            Console.WriteLine($"So ngay cua thang {thang} nam {nam} la {ngay}");
            */

            /* Bai 102: Tim ngay ke tiep
            int ngay, thang, nam;
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            int ngaytrongthang = 31;

            if (thang == 2)
            {
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    ngaytrongthang = 29;
                }
                else
                {
                    ngaytrongthang = 28;
                }
            }
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                ngaytrongthang = 30;
            }
            int ngaykt, thangkt, namkt;
            ngaykt = ngay + 1;
            thangkt = thang;
            namkt = nam;
            if (ngaykt > ngaytrongthang)
            {
                ngaykt = 1;
                thangkt = thangkt + 1;
            }
            if (thangkt > 12)
            {
                thangkt = 1;
                namkt = nam + 1;
            }
            Console.WriteLine($"Ngay ke tiep la {ngaykt}/{thangkt}/{namkt}.");
            */

            /* Bai 1: Tinh tong S(n)
            int i, n, S;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            S = 0;
            i = 1;
            while (i <= n)
            {
                S = S + i;
                i = i + 1;
            }
            Console.WriteLine($"Tong S({n}) la {S}");
            */

            /* Bai 2: Tinh tong S(n) = 1^2 + 2^2 + ... +n^2
            int i, n, S;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            S = 0;
            i = 1;
            while (i <= n)
            {
                S = S + i * i;
                i = i + 1;
            }
            Console.WriteLine($"Tong S({n}) la {S}");
            */

            /* Bai 3: Tinh Tong S(n) = 1 + 1/2 + 1/3 + ... + 1/n
            int i, n;
            double S;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            S = 0;
            i = 1;
            while (i <= n)
            {
                S = S + (1 / i);
                i = i + 1;
            }
            Console.WriteLine($"Tong S({n}) la {S}");
            */

            /* Bai 9: Tinh Tich (n) = 1 * 2 * 3 * ... * n
            int i, n, T;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            T = 1;
            i = 1;
            while (i <= n)
            {
                T = T * i;
                i = i + 1;
            }
            Console.WriteLine($"Giai thua {n} la {T}");
            */

            /* Bai 10: Tinh x^n
            double x, n, T;
            Console.Write("Nhap so x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            T = Math.Pow(x,n);
            Console.WriteLine($"{x} ^ {n} la {T}");
            */

            /* Bai 11: Tinh Tich S(n) = 1 + 1*2 + 1*2*3 + ... + 1*2*3*...*n
            int i, n, T, S;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            T = 1;
            S = 0;
            i = 1;
            while (i <= n)
            {
                T = T * i;
                S = S + T;
                i = i + 1;
            }
            Console.WriteLine($"Tong S({n}) la {S}");
            */

            /* Bai 12: Tinh Tong S(n) = x + x^2 + x^3 + ... +x^n
            double x, n, T, S;
            Console.Write("Nhap so x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            int i = 1; // de i = 0 thi se du so 1
            S = 0;
            while(i <= n)
            {
                T = Math.Pow(x,i); //luc dau bi sai do quen the i ma van de n
                S = S + T;
                i = i + 1;
            }
            
            Console.WriteLine($"Tong {x} ^ {n} la {S}");
            */

            /* Bai 13: Tinh Tong S(n) = x^2 + x^4 + ... +x^2n
            double x, n, T, S;
            Console.Write("Nhap so x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            int i = 1; 
            S = 0;
            while(i <= n)
            {
                T = Math.Pow(x,2*i);
                S = S + T;
                i = i + 1;
            }
            
            Console.WriteLine($"Tong {x} ^ {n} la {S}");
            */
            
            /* Bai 14: Tinh Tong S(n) = x^1 + x^3 + x^5 +... +x^2n+1
            double x, n, T, S;
            Console.Write("Nhap so x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            int i = 0; // de i = 0 thi moi tinh ra so le
            S = 0;
            while(i <= n)
            {
                T = Math.Pow(x,(2*i)+1); //2n + 1 la cach de ra so le, 
                S = S + T;
                i = i + 1;
            }
            
            Console.WriteLine($"Tong {x} ^ {n} la {S}");
            */

            /* Bai 20: Liet ke tat ca cac uoc so cua so nguyen n
            int n;
            Console.Write("Nhap so n: ");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                i = i + 1;
            }
            Console.WriteLine(n);
            */

            /* Bai 31: Kiem tra so nguyen to
            int n;
            Console.Write("Nhap so N: ");
            n = int.Parse(Console.ReadLine());
            bool laNguyento = true;
            if (n < 1)
            {
                laNguyento = false;
            }
            else
            {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    laNguyento = false;
                }
            }
            }
            if (laNguyento == true)
            {
            Console.WriteLine($"So {n} la so nguyen to");
            }
            else
            {
            Console.WriteLine($"So {n} khong la so nguyen to");
            }
            */
            /* Bai 30: kiem tra so hoan thien
            int N;
            Console.Write("Nhap so N:");
            N = int.Parse(Console.ReadLine());
            //Tim uoc so
            int S = 0;
            for(int i = 1; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    S = S + i;
                }
            }
            bool lasoHoanthien = (S == N);
            Console.WriteLine($"So {N} la so hoan thien: {lasoHoanthien}");
            /* if (S == N)
            {
                Console.WriteLine($"So {N} la so hoan thien, co tong uoc so la {S} ");
            }
            else
            {
                Console.WriteLine($"So {N} KHONG la so hoan thien, co tong uoc so la {S}");
            }
            */
            // Bai 109: Viet chuong tỉnh in bang cuu chuong
           /*  int n;
            Console.Write("Nhap bang cuu chuong muon in: ");
            n = int.Parse(Console.ReadLine());
            */
            /* int T;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    T = i * j;
                    Console.WriteLine($"{i} * {j} = {T}");
                }
                Console.WriteLine("--------------------");
            }
            */
            /* Bai 11: Tinh Tong giai thua dung ham ngoai
            int N, S;
            Console.Write("Nhap so tinh tong giai thua: ");
            N = int.Parse(Console.ReadLine());
            S = TinhTongGiaiThua(N);
            Console.WriteLine($"Tong cua Giai thua so {N} la {S}");
            */
            /* Bai : Kiem tra so nguyen to bang ham
            int N;
            Console.Write("Nhap so can kiem tra la so nguyen to: ");
            N = int.Parse(Console.ReadLine());
            bool kq = KTsoNguyento(N);
            Console.WriteLine(kq);
            */
        }
    }
}
