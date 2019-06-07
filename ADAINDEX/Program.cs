using System;
using System.Text;

namespace ADAINDEX
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] N = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries), int.Parse);

            int words =N[0];
            int queries = N[1];

            string[] slowa = new string[words];
            for (int i = 0; i < words; i++)
            {

                slowa[i] = Console.ReadLine();


            }



            for (int j = 0; j  < queries; j ++)
            {
                string sub = Console.ReadLine();
                sb.Append(solution1(slowa,sub ) + "\n");




            }
            Console.WriteLine(sb);
        }


        static int solution1(string[] slowa, string sub)
        {
            int sol =0;
            for (int z = 0; z < slowa.Length; z++)
            {

                if (slowa[0].Contains(sub)) sol++;

            }

            return sol;
        }
    }
}
