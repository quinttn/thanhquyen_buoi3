using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan_KhongDeQui
{
    internal class TimKiemNhiPhan_KhongDeQui
    {
        static void Main()
        {
            int[] a;
            int n, x;

            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            a = new int[n];

            nhapMang(a, n);
            Console.WriteLine("Mang sau khi nhap:");
            xuatMang(a, n);

            Array.Sort(a);

            Console.WriteLine("Mang sau khi sap xep:");
            xuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            x = int.Parse(Console.ReadLine());

            int kq = BinarySearch(a, 0, n - 1, x);

            if (kq == -1)
                Console.WriteLine($"\nKhong tim thay {x} trong mang");
            else
                Console.WriteLine($"\nTim thay {x} tai vi tri thu {kq}");
        }

        static void nhapMang(int[] a, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(1, 100);
            }
        }

        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static int BinarySearch(int[] a, int left, int right, int x)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                if (a[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
