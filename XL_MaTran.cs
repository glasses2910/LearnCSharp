using System;

namespace learnC_
{
    class XL_MaTran
    {
        // Bai 381: Tim Gia tri xuat hien nhieu lan trong Ma tran
        public static int DemSoLanXuatHien (int [,] A, int k)
        {
            int Dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == k)
                    {
                        Dem++;
                    }
                }
            }
            return Dem;
        }
        public static int TimSoLanXuatHien(int [,] A)
        {
            int kq = A[0, 0];
            int DemMax = DemSoLanXuatHien(A, kq);
             for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int Dem = DemSoLanXuatHien(A, A[i, j]);
                    if (Dem > DemMax)
                    {
                        DemMax = Dem;
                        kq = A[i, j];
                    }
                }
            }
            return kq;
        }

        // Bai 354: Kiem tra cac gia tri  co giam tdan theo dong va cot trong Ma tran
        // Lam lai bai nay su dung ham KTraGiamDan roi qua cot xem sao; co bai lam trong video
        public static bool KTraGiamDanMT (int[,] A)
        {
            int b = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] >= b)
                    {
                        return false;
                    }
                    b = A[i, j]; //Gan phan tu moi cho bien, neu khong cho so so dau tien cua Ma tran
                }
            }
            return true;   
        }

        // Bai 352: Kiem tra 1 dong co tang ko
        public static bool KTraTangDan (int [,] A, int k)
        {
            for (int j = 0; j < A.GetLength(1) - 1; j++) // chay den phan tu ke cuoi, neu den cuoi thi lay gi so sanh
            {
                if (A[k, j] > A[k, j + 1])
                {
                    return false;
                }
            }
            return true;
        }
        
        // Bai 351: Kiem tra Ma tran co toan duong ko
        public static bool KTraMaTranDuong (int [,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] <0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // Bai 328: Tinh Cot
        public static int TichCotMaTran (int [,] A, int k)
        {
            int S = 1;
            if (k <= A.GetLength(1))
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    S = S * A[i, k];
                }
            }
            else
            {
                Console.WriteLine("Khong tinh duoc tong dong");
            }
            return S;
        }
        // Bai 324 Tinh Tong cac gia tri tren 1 dong cua Ma tran
        public static int TongDongMaTran (int [,] A, int k)
        {
            int S = 0;
            if (k <= A.GetLength(0))
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[k, j];
                }
            }
            else
            {
                Console.WriteLine("Khong tinh duoc tong dong");
            }
            return S;
        }
        // Bai 327 Tinh Tong cac gia tri nam tren bien cua ma tran (khong tinh trung, phai bo phan trung)
        public static int TongCacBien (int [,] A)
        {
            int S = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                S = S + A[0, j];
                S = S + A[A.GetLength(0) - 1, j];
            }
            for (int i = 1; i <A.GetLength(0) - 1; i++)
            {
                S = S + A[i, 0];
                S = S + A[i, A.GetLength(1) - 1];
            }
            return S;
        }
        
        
        //Bai 317 Dem so nguyen to trong ma tran so nguyen
        public static int DemNguyenTo (int [,] A)
        {
            int Dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (XuLySoNguyen.KTsoNguyento(A[i,j]) == true)
                    {
                        Dem = Dem + 1;
                    }
                }
            }
            return Dem;
        }
        public static int PtuLonNhat (int [,] A)
        {
            int max = A[0, 0];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }
        public static int [,] NhapMaTran ()
        {
            int [,] A;
            Console.Write("Nhap so cot: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong: ");
            int M = int.Parse(Console.ReadLine());

            A = new int [N,M];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"Nhap phan tu A[{i}, {j}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }

        public static void XuatMaTran(int [,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        public static int TongMaTran (int [,] A)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S = S + A[i, j];
                }
            }
            return S;
        }
    }
}