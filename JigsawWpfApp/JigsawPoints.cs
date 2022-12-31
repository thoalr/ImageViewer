using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JigsawWpfApp
{
    class JigsawPoints
    {
        private Random _random = new Random(42);
        public JigsawPoints() { }


        public List<Point> GenerateTopSide()
        {
            var startPoint = new Point(0.0, 0.0);

            double x_min = 0.5 - (3.0 / 30.0);
            double x_max = x_min;
            double x_rand = x_max;
            double y_min = -1.0 / 30.0;
            double y_max = -2.0 / 30.0;
            double y_rand = RandomLinear(y_min, y_max);
            var p1 = new Point(x_rand, y_rand);

            x_min = 0.5 - (3.0 / 60.0);
            x_max = 0.5 - (3.0 / 60.0);
            x_rand = RandomLinear(x_min, x_max);
            y_min = 1.0 / 30.0;
            y_max = 3.0 / 30.0;
            y_rand = RandomLinear(y_min, y_max);
            var p2 = new Point(x_rand, y_rand);

            x_min = (7.0 / 30.0);
            x_max = (9.0 / 30.0);
            x_rand = RandomLinear(x_min, x_max);
            y_min = 4.0 / 30.0;
            y_max = 6.0 / 30.0;
            y_rand = RandomLinear(y_min, y_max);
            var p3 = new Point(x_rand, y_rand);

            //x_min = 0.5;
            //x_max = x_min;
            x_rand = 0.5;
            y_min = 6.0 / 30.0;
            y_max = 9.0 / 30.0;
            y_rand = RandomLinear(y_min, y_max);
            var p4 = new Point(x_rand, y_rand);


            var endPoint = new Point(1d, 0d);

            return new List<Point>{startPoint, p1, p2, p3, p4, endPoint}.Select((p) => { p.X = p.X * 200d + 60d; p.Y = p.Y * 200d + 60d; return p; }).ToList();
        }

        private double RandomLinear(double min, double max)
        {
            return _random.Next() * (max - min) + min;
        }

    }
}
