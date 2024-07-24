using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan_DeQui
{
    internal class TimKiemNhiPhan_DeQui
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
            xuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            x = int.Parse(Console.ReadLine());

            int kq = binarySearch(a, 0, n - 1, x);

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
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static int binarySearch(int[] a, int left, int right, int key)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (a[mid] == key)
                return mid; 

            if (key < a[mid])
                return binarySearch(a, left, mid - 1, key);
            else
                return binarySearch(a, mid + 1, right, key);
        }
    }
}
