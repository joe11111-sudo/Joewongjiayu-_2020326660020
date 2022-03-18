using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. 随机生成100个0~1000间的整数，使用LINQ语句对这些整数从大到小排序，并求和与平均数。
namespace 作业4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double sum = 0;
            int[] arr = new int[100];
            Random random = new Random();

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1000) + 1;
            }

            double[] arr_sqrt = arr.Select(x => Math.Sqrt(x)).OrderByDescending(x => x).ToArray();
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0  :  0.0000}", arr_sqrt[i]);
                sum += arr_sqrt[i];
            }
            Console.WriteLine("sum: {0  : 0.0000} ", sum);
            Console.WriteLine("average: {0  : 0.0000} ", sum / 100);
        }
    }
}