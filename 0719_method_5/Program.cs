using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0719_method_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[5][];

            Random r = new Random();

            int[] a2 = new int[5];

            for (int i =0; i<a.Length; i++)
            {
                a[i] = new int[5];

                for (int j=0; j<a.Length; j++)
                {
                    int ra = r.Next(1, 101);
                    a[i][j] = ra;
                    a2[i] += a[i][j];
                    Console.Write(a[i][j] + "  ");
                    
                }
                

                if (a2[i] / 5 >= 90)
                {
                    Console.Write((i + 1) + "번학생의 " + "합 : " + a2[i] + " 평균 : " + a2[i] / 5 + " "+ " 학점은 A 입니다. ");
                    Console.WriteLine();
                }
                else if (a2[i] /5 >79)
                {
                    Console.Write((i + 1) + "번학생의 " + "합 : " + a2[i] + " 평균 : " + a2[i] / 5 + " " + " 학점은 B 입니다. ");
                    Console.WriteLine();
                }
                else if (a2[i]/5 > 69)
                {
                    Console.Write((i + 1) + "번학생의 " + "합 : " + a2[i] + " 평균 : " + a2[i] / 5 + " " + " 학점은 C 입니다. ");
                    Console.WriteLine();
                }
                else if (a2[i]/5 >59)
                {
                    Console.Write((i + 1) + "번학생의 " + "합 : " + a2[i] + " 평균 : " + a2[i] / 5 + " " + " 학점은 D 입니다. ");
                    Console.WriteLine();
                }
                else 
                {
                    Console.Write((i + 1) + "번학생의 " + "합 : " + a2[i] + " 평균 : " + a2[i] / 5 + " " + " 학점은 F 입니다. ");
                    Console.WriteLine();
                }
                
            }
            



        }

       
    }
}
