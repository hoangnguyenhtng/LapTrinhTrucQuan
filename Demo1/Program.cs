using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    class Program
        {
            static void Main(string[] args)
            {
                PTB2 pt = new PTB2();
                string s = pt.Giapt();
                Console.WriteLine(s);

            }
        }
    }
