using System;

namespace MANGMOTCHIEU
{
    class ThemPhanTuVaoMang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n+1];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Phan tu vi tri {0}: ", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap so muon chen vao mang:");
            int sochen = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri muon chen vao mang:");
            int vitri = int.Parse(Console.ReadLine());
            if (vitri<0||vitri>=n+1) return;
            for(int i = n; i >= vitri; i--)
            {
                if(i==0) break;
                mang[i] = mang[i-1];
            }
            mang[vitri] = sochen;
            for(int i = 0; i < n+1; i++)
            {
                Console.WriteLine(mang[i]);
            }
        }
    }
}