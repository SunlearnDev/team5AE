﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNhacCaNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListSinger singers = new ListSinger();
            singers.ReadDB();
            singers.Xuat();
            singers.Xoa();
            Console.ReadKey();
        }
    }
}
