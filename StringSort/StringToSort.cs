using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToSort
{
    public class StringToSort
    {
        public int[] GetAsciiArray(string str)
        {

            return str.Where(c => (!Char.IsWhiteSpace(c) && !char.IsPunctuation(c)))
                                                  .Select(c => char.IsUpper(c) ? System.Convert.ToInt32(char.ToLower(c)) : System.Convert.ToInt32(c))
                                                  .ToArray();
        }

        public string ArrayToSort(int[] arr, int n, int min, int max)
        {
            int m = max - min + 1;
            int[] c = new int[m];
            string result = "";
            for (int i = 0; i < n; i++)
            {
                c[arr[i] - min]++;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < c[i]; j++)
                {
                    result += (char)(i + min);

                }
            }
            return result;
        }
    }
}
