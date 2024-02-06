using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapFunctionMethod_Dem1KyTuTrongChuoi
{
    internal class Program
    {
        public static int DemKyTu(string str, char item)
        {
            int count = 0;
            str = str.Replace(" ", string.Empty);

            for (int i = 0; i < str.Length; i++)
            {
                char str_item = (char)str[i];
                if (str_item == item)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int count = 0;

            Console.Write("Nhap vao chuoi: ");
            string str = Console.ReadLine();

            //Xóa khoảng trắng khỏi chuỗi
            str = str.Replace(" ", string.Empty);

            Console.Write("Nhap vao ky tu can dem: ");
            char item = char.Parse(Console.ReadLine());

            count = DemKyTu(str, item);

            if (count == 0)
            {
                Console.WriteLine("Khong ton tai ky tu " + item + " trong chuoi tren");
            }
            else
            {
                Console.WriteLine("Co tat ca " + count + " ky tu " + item + " trong chuoi tren");
            }

            Console.ReadKey();
        }
    }
}
