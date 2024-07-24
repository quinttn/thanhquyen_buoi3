using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTong_KhongDeQui
{
    internal class TinhTong_KhongDeQui
    {
        static void Main()
        {
            nhapMang(out int[] a, out int n);
            Console.WriteLine("Mang da nhap:");
            xuatMang(a, n);

            int ketqua = Sum(a, 0, n - 1);
            Console.WriteLine($"\nKet qua (khong de qui): {ketqua}");
        }

        static void nhapMang(out int[] a, out int n)
        {
            Random rand = new Random();
            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            a = new int[n];

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

        //static int Sum(int[] a, int l, int r)
        //{
        //    if (l == r)
        //        return a[l];

        //    int mid = (l + r) / 2;
        //    int temp1 = Sum(a, l, mid);
        //    int temp2 = Sum(a, mid + 1, r);
        //    return temp1 + temp2;
        //}

        static int Sum(int[] a, int l, int r)
        {
            int sum = 0;
            for (int i = l; i <= r; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
