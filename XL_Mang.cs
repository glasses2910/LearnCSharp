using System;

namespace learnC_
{
    class XL_Mang
    {
        public static int TimViTriXuatHien (int [] A, int v) //Tim vi tri trong mang voi 1 so cho truoc
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == v)
                {
                    return i;
                }
            }
            return -1;
        }
        // Bai 235 Dem gia tri xuat hien o 2 mang
        public static void DemXuatHien2Mang (int [] A, int [] B)
        {
            for (int i = 0; i < A.Length; i++) // Tim trong mang A
            {
                if(TimViTriXuatHien(B, A[i]) == -1)
                {
                    Console.WriteLine(A[i]);
                }
            }
            for (int i = 0; i < B.Length; i++) // Tim trong mang B
            {
                if(TimViTriXuatHien(A, B[i]) == -1)
                {
                    Console.WriteLine(B[i]);
                }
            }
        }
        // Bai 230: Dem so lan xuat hien cua phan tu
        public static void DemSoLanXuatHien (int [] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool DaDem = false;
                for (int j = 0; j < i; j++)
                {
                    if(A[j] == A[i]) // Xac dinh phan tu trung de dem
                    {
                        DaDem = true;
                        break;
                    }
                }
                if (DaDem == false)
                {
                int Dem = 0;
                for (int j = i; j < A.Length; j++) // Da dem truoc roi, nen bat dau tu i
                {
                    if (A[j] == A[i])
                    {
                        Dem = Dem + 1;    
                    }
                }    
                Console.WriteLine($"Phan tu {A[i]} xuat hien {Dem}");
                }
            }
            
        }
        // Bai 214: Tinh Trung binh nhan cac so thuc nguyen (duong thi dung Ham NhapMang double)
        public static double TinhTBNSoDuong (int [] A)
        {
            int T = 1;
            int Dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    T = T * A[i];
                    Dem = Dem + 1;
                }
            }
            if (Dem > 0)
            {
                return Math.Pow(Dem,T);
            }
            return 0;
        }
        public static double TinhTBCSoDuong (int [] A) // Bai 212: Trung binh cong so duong
        {
            int S = 0;
            int Dem = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    S = S + A[i];
                    Dem = Dem + 1;
                }
            }
            if (Dem > 0)
            {
                return S * 1.0 / Dem;
            }
            return 0;
        }
        public static double TinhTBCSoNgTo (int [] A) // Bai 211: Tinh Trung binh cong cac so nguyen to trong mang
        {
            int S = 0;
            int Dem = 0; // them bien Dem de Dem so lan xuat hien cua so nguyen to
            for (int i = 1; i < A.Length; i++)
            {
                if (XuLySoNguyen.KTsoNguyento(A[i]) == true)
                {
                    S = S + A[i];
                    Dem = Dem + 1;
                }
            }
            if (Dem > 0)
            {
                return 1.0 * S / Dem;
            }
            return 0;
        }
        public static int TimGiaTriChanCC (int [] A) // Bai 136 Tim gia tri chan cuoi cung trong mang --> AKA tim nguoc
        {
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] % 2 == 0)
                {
                    return A[i];
                }
            }
            return -1;
        }
        public static int TimGiaTriDuongDauTien (int [] A) // Bai 135
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    return A[i];
                }
            }
            return -1;
        }
        /* Tim gia tri Duong dau tien, khong co tra ve -1 --> tu code
        public static int TimGiaTriDuongDauTien (int [] A)
        {
            int gtriDuong = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    gtriDuong = A[i];
                    break;
                }
            }
            return gtriDuong;
        }
        */
        public static void LiekeGiatriChan(int [] A) // Bai 132
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Console.WriteLine(A[i]);
                } 
            }
        }
        public static int TimViTriPhanTuMin (int [] A) // Tim vi tri phan tu co gia tri nho nhat - Bai 123??
        {
            int Min = A[0];
            int vitri = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < Min)
                {
                    vitri = i; // co loi khi hai phan tu am thi hien o vi tri cuoi cung
                }
            }
            return vitri;
        }
        public static int TinhTongPtuAm (int [] A) // Bai 126
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    S = S + A[i];
                }
            }
            return S;
        }
        public static int TimMax (int [] A) // Bai 134
        {
            int Max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > Max)
                {
                   Max = A[i]; 
                }
            }
            return Max;
        }
        public static int TimMin (int [] A)
        {
            int Min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < Min)
                {
                    Min = A[i];
                }
            }
            return Min;
        }
        public static int[] NhapMang ()
        {
            int [] A;
            Console.Write("Nhap so luong phan tu mang: ");
            int N = int.Parse(Console.ReadLine());
            A = new int [N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Nhap A[{i}]");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        public static void XuatMang(int [] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
