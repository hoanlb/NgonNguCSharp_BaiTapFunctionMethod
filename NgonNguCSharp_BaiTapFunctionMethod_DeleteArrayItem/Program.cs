using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapFunctionMethod_DeleteArrayItem
{
    internal class Program
    {
        public static void ArrayInput(int n, int[] arr1)
        {
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void ArrayDeleteItem(int n, int[] arr1, int pos)
        {
            /* xac dinh vi tri cua i trong mang*/
            int i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;

            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }

        static void Main(string[] args)
        {
            int pos, n; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrayInput(n, arr1);

            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            ArrayDeleteItem(n, arr1, pos);

            Console.ReadKey();
        }
    }
}
