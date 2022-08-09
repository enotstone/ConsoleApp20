using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main()
        {
            Console.WriteLine("Input Radius");
            double R = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDel = VBall;
            myDel += LRound;
            myDel += SRound;
            
            myDel(R);
            
            Console.ReadKey();
        }
        static double LRound(double r)
        {
            double resAc = 2 * Math.PI * r;
            Console.WriteLine("Long round = {0}",resAc);
            return resAc;
        }
        static double SRound(double r)
        {
            double resAc = Math.PI * r * r;
            Console.WriteLine("Area of ​​a circle = {0}", resAc);
            return resAc;
        }
        static double VBall(double r)
        {
            double resAc = 4 * Math.PI * (r * r * r) / 3;
            Console.WriteLine("Ball volume = {0}", resAc);
            return resAc; 
        }
    }
}
