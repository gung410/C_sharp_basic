using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_Basic;


namespace C_Sharp_Basic
{

    class Program
    {

        //void Value_Type()
        //{
        //    int a = 5;
        //    int b = a;
        //    a = a + 1;
        //    Console.WriteLine("\nValue_Type");
        //    Console.WriteLine("b={0}", b);
        //    Console.WriteLine("a={0}", a);

        //}
        //void Reference_Type()
        //{
        //    int[] a = { 1, 3, 4, 5 };
        //    int[] b = a;
        //    int[] c = a;
        //    a[0] = 5;

        //    Console.WriteLine("\nReference_Type");
        //    Console.WriteLine("b={0}", b[0]);
        //    Console.WriteLine("c={0}", c[0]);
        //}

        //    enum Color //dùng dễ liệt kê những thứ cố định 
        //{
        //    red , blue , green
        //}
           
        //String MauSac(Color color)
        //{
        //    if (color == Color.blue || color == Color.red)
        //    {
        //        return "MauDep";
        //    }
        //    else
        //        return "MauXau";
        //}


        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Value_Type();
            //p.Reference_Type();
            //_______________ENUM____________________
            //p.MauSac(Color.blue);
            //Console.WriteLine("{0}", p.MauSac(Color.blue));

            //Array Mau = Enum.GetValues(typeof(Color));

            //foreach(Color cl in Mau)
            //{
            //    Console.WriteLine("\nmau :" + cl);
            //}
            LinQ_To_Object lq = new LinQ_To_Object();
            lq.lin();
            //string a = "niuniuninh agasda";
            //a.wordcout();
         //   Console.WriteLine("{0}", a.wordcout());
            Console.ReadLine();
        }
    }
}
