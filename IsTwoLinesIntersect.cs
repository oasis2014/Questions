using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class TwoLinesIntersect
    {
        public struct Line
        {
            public double slope;
            public double yintercept;
        }
        /*
         * Given two lines on a Cartesian plane, determine whether the two lines would intersect
         * */
        public static bool IsTwoLinesIntersect(Line line1, Line line2)
        {
            const double epsilon = 0.000001;
            return System.Math.Abs(line1.slope - line2.slope) > epsilon || System.Math.Abs(line1.yintercept - line2.yintercept) < epsilon;
        }

        public static void TestIntersectTwoLines()
        {
            Line line1 = new Line();
            line1.slope = 0.44;
            line1.yintercept = 3.4;

            Line line2 = new Line();
            line2.slope = 9.00;
            line2.yintercept = -256.0;

            Console.WriteLine(IsTwoLinesIntersect(line1, line2));
            Console.ReadLine();
        }
    }
}
