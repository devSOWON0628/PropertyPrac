using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            box luckybox = new box(10, 10);
            luckybox.Area();
            luckybox.width = -10;
        }
    }
}
