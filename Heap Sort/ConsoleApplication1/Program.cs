using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void heapSort(int[] dizi, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)           // 2*i  Sol child    2*i+1  sağ child
                heapify(dizi, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;
                heapify(dizi, i, 0);
            }
        }
        static void heapify(int[] dizi, int n, int i)
        {
            int enbuyuk = i;
            int sol = 2 * i + 1;
            int sag = 2 * i + 2;
            if (sol < n && dizi[sol] > dizi[enbuyuk])
                enbuyuk = sol;
            if (sag < n && dizi[sag] > dizi[enbuyuk])
                enbuyuk = sag;
            if (enbuyuk != i)
            {
                int swap = dizi[i];
                dizi[i] = dizi[enbuyuk];
                dizi[enbuyuk] = swap;
                heapify(dizi, n, enbuyuk);
            }
        }
        public static void Main()
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;
            Console.WriteLine("Heap Sort");
            Console.Write("Verilen dizi: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            heapSort(arr, 10);
            Console.Write("\nSıralanan Dizi: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
} 
