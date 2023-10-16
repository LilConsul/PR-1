using System;

namespace PR_1 {
    internal class Table {
        public double[,] xy { get; private set; }
        public int n { get; private set; }

        public Table() {
            xy = new double[1000, 2];
            n = 0;
        }

        private double ctg(double x) {
            return 1.0 / Math.Tan(x);
        }

        private double f1(double x) {
            return Math.Pow(x, 5) + ctg(Math.Pow(2 * x, 3));
        }

        private double f2(double x) {
            return 5 / Math.Tan(2 * x + 1) + 1;
        }

        private double f3(double x) {
            return Math.Tan(Math.Pow(x, 2) + 1) * Math.Pow(Math.E, -x);
        }

        public void Calc(double xn = 3.75, double xk = 17.7, double h = 0.4, double a = 0.8) {
            double x = xn, y = 0.0;
            int i = 0;
            while (x < xk) {
                if (x < 0)
                    y = f1(x);
                else {
                    if ((x >= 0) && (x < a))
                        y = f2(x);
                    else
                        y = f3(x);
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }

            n = i;
        }
    }
}