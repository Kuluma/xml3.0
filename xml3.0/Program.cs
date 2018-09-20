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
            devProps.Load();
            //TrainWin trainWin = new TrainWin();
            //trainWin.TrainWinLoad();

            foreach (var item in DevProps.trainWins)
            {
                Console.WriteLine(item.name.ToString());
            }
            foreach (var item in DevProps.tracks)
            {
                Console.WriteLine(item.Alias.ToString());
            }

            Layout layout = new Layout();
            layout.Load();
            foreach (var item in Layout.Layout_trainWins)
            {
                Console.WriteLine(item.name.ToString());
            }
            Console.ReadLine();
        }
    }
}
