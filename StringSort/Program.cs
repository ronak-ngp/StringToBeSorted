using System;

namespace StringToSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter string to be sorted");
                string input = Console.ReadLine();
                StringToSort stringSort = new StringToSort();
                int[] asciiArray = stringSort.GetAsciiArray(input);
                Console.Write(stringSort.ArrayToSort(asciiArray, asciiArray.Length, 97, 122));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
