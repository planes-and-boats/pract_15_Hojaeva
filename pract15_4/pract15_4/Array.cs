using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract15_4
{
    class Array
    {
        private int[] data;

        public Array(int size)
        {
            data = new int[size];
        }
        public void FullArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1, 10);
            }
        }
        public void Multiply(int factor)
        {
            for (int i = 0; i < data.Length; i++) data[i] *= factor;
        }
        public static Array Sum(Array a, Array b)
        {
            int minLen = Math.Min(a.Length, b.Length);
            Array res = new Array(minLen);
            for (int i = 0; i < minLen; i++) res.data[i] = a.data[i] + b.data[i];
            return res;
        }
        public static Array Sub(Array a, Array b)
        {
            int minLen = Math.Min(a.Length, b.Length);
            Array res = new Array(minLen); 
            for (int i = 0; i < minLen; i++) res.data[i] = a.data[i] - b.data[i];
            return res;
        }
        public bool Search(int index, out int item)
        {
            item = -1;
            if (index < 0) return false;
            else if (index > data.Length - 1) return false;
            else
            {
                item = data[index];
                return true;
            }
        }
        public int Length => data.Length;
        public void PrintAll() => Console.WriteLine(string.Join(" ", data));
    }

}
