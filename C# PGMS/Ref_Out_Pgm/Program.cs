using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out_Pgm
{
    internal class Program
    {
        public static void AddNum(ref int num)
        {
            num++;
        }
        public static void rectangle(int length, int width, out int area, out int perimeter)
        {
            area = length * width;
            perimeter = 2 * (length + width);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a no : ");
            int num = Convert.ToInt32(Console.ReadLine());
            AddNum(ref num);
            Console.WriteLine("Add : " + num);


            Console.Write("Enter the length : ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width : ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area;
            int perimeter;
            rectangle(length, width, out area, out perimeter);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Perimeter : " + perimeter);
            Console.ReadLine();
        }
    }
}
