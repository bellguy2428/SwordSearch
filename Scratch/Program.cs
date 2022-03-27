using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 129070174.0914039308;            
            double mins = time / 60000;
            string minutes = mins.ToString("N0");
            double secs = (mins - (Convert.ToDouble(minutes))) * 60;            
            string seconds = secs.ToString("N3");



            double m = Convert.ToDouble(minutes);
            double s = Convert.ToDouble(seconds);
            double milsec = time - (m + s);
            string milliseconds = milsec.ToString("N3");


            Console.WriteLine($"{minutes}:{seconds}");
            Console.ReadKey();
        }
    }
}
