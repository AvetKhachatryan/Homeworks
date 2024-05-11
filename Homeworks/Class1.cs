using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    public class Class1
    {
        //xndir 1
        public List<int> MergeSort(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            foreach(int i in arr1)
            {
                result.Add(i);
            }
            foreach(int i in arr2)
            {
                result.Add(i);
            }
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = i; j < result.Count; j++)
                {
                    if (result[i] > result[j])
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        public void printResult(List<int> result)
        {
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
        //xndir 2
        public static int ObjCount = 0;
        public Class1()
        {
            ObjCount++;
        }
    }
}
