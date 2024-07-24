using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_DeQui
{
    internal class QuickSort_DeQui
    {
        static void Main()
        {
            nhapMang(out int[] a, out int n);
            Console.WriteLine("Mang da nhap:");
            xuatMang(a, n);
            Console.WriteLine("\nMang sau khi sap xep la:");
            quickSort(a, 0, n - 1);
            xuatMang(a, n);
        }

        static void nhapMang(out int[] a, out int n)
        {
            Random rand = new Random();
            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

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

        static void quickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = partition(a, left, right);
                quickSort(a, left, s - 1); // Gọi đệ qui để sắp xếp nửa đầu của mảng
                quickSort(a, s + 1, right); // Gọi đệ qui để sắp xếp nửa sau của mảng
            }
        }

        static int partition(int[] a, int left, int right)
        {
            int pivot = a[right]; 
            int i = left - 1; 

            for (int j = left; j < right; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    swap(ref a[i], ref a[j]);
                }
            }

            swap(ref a[i + 1], ref a[right]); 
            return i + 1;
        }

        static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
}