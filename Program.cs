using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idexersample
{
    class Program
    {
        string[] str= new string[6];
        public string this[int index]
        {
            get => str[index];
            set => str[index] = value;
        }
    }
    class program1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p[1] = "aaa";
            p[2] = "bbb";
            p[3] = "ccc";
            p[4] = "ddd";
            p[5] = "eee";
            p[0] = "fff";
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(p[i]);
            Console.WriteLine(p[0]);
            Console.ReadLine();
        }
    }
}
