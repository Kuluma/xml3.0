using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            DevProps devProps = new DevProps();
            devProps.DevPropsLoad();
            Console.ReadLine();
        }
    }
}
