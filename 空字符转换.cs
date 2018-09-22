using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string a = "0.2";
                //string a = null;
                string a = null;
                try
                {
                    double d1 = Double.Parse(a);
                    Console.WriteLine("d1\t"+d1);
                }
                catch (Exception err)
                {
                    Console.WriteLine("d1转换出错:\t" + err.Message);
                }

                try
                {
                    double d2 = Convert.ToDouble(a);
                    Console.WriteLine("d2:\t"+d2);
                }
                catch (Exception err)
                {
                    Console.WriteLine("d2转换出错:" + err.Message);

                }
                try
                {
                    double d3;
                    Console.WriteLine("result\t"+Double.TryParse(a,out d3));
                }
                catch (Exception err)
                {
                    Console.WriteLine("d3转换出错:\t" + err.Message);
                }
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}