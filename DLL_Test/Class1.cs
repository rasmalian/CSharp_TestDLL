using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace DLL_Test
{
    public class tmp
    {
        private int var1 = 0;

        public int var { get; set; }

        public void pirntvar()
        {
            var = var1;
            Console.WriteLine("var = " + (var+1).ToString());
        }

    }
}
