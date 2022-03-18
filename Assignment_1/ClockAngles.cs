using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Asgmt
{
    public class ClockAngles
    {
        public static void ClockUI()
        {
            Console.Write("Hours: ");
            var h = Console.ReadLine();
            Console.Write("Minutes: ");
            var m = Console.ReadLine();

            Console.WriteLine("Angle: " + CalcAngle(double.Parse(h), double.Parse(m)));
        }

        public static int CalcAngle(double h, double m)
        {
            if (h < 0 || h > 12 || m < 0 || m > 60)
            {
                Console.Write("Wrong input");
                Environment.Exit(0);
            }

            if (h == 12)
            {
                h = 0;
            }

            if (m == 60)
            {
                m = 0;
                h += 1;

                if (h > 12)
                {
                    h = h - 12;
                }
            }

            int hAngle = (int)(0.5 * (h * 60 + m));
            int mAngle = (int)(6 * m);

            int angle = Math.Abs(hAngle - mAngle);

            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
