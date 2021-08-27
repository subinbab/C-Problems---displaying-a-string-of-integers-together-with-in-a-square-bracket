using System;

namespace csharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10,23,45,67,22,47,89};
            Console.WriteLine("[");
            for(int i =0;i<a.Length-1;i++){
                Console.Write(a[i]+",");
            }

            Console.Write(a[a.Length-1]+"]");
        }
    }
}
