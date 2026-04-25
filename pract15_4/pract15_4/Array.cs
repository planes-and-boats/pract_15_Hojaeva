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
        public Array(int[] array)
        {
            data = array;
        }
        public void FullArray()
        {
            Random rnd = new Random();
            data = Enumerable.Range(0, data.Length).Select(i => rnd.Next(1, 10)).ToArray();
        }
        public void Multiply(int factor)
        {
            data = data.Select(x => x * factor).ToArray();
        }
        public static Array Sum(Array a, Array b)
        {
            var resData = a.data.Zip(b.data, (x, y) => x + y).ToArray();
            return new Array(resData);
        }
        public static Array Sub(Array a, Array b)
        {
            var resData = a.data.Zip(b.data, (x, y) => x - y).ToArray();
            return new Array(resData);
        }
        public bool Search(int index, out int item)
        {
            if (index < 0 && index > data.Length - 1)
            {
                item = -1;
                return false;
            }
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
