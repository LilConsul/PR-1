using System;

namespace PR_1 {
    public class Table {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double Ctg(double x) {
            return 1.0 / Math.Tan(x);
        }

        private double F1(double x) {
            return Math.Pow(x, 5) + Ctg(Math.Pow(2 * x, 3));
        }

        private double F2(double x) {
            return 5 / Math.Tan(2 * x + 1) + 1;
        }

        private double F3(double x) {
            return Math.Tan(Math.Pow(x, 2) + 1) * Math.Pow(Math.E, -x);
        }

        public void Calc(double xn = 3.75, double xk = 17.7, double h = 0.4, double a = 0.8) {
            double x = xn, y = 0.0;
            int i = 0;
            while (x < xk) {
                if (x < 0)
                    y = F1(x);
                else {
                    if ((x >= 0) && (x < a))
                        y = F2(x);
                    else
                        y = F3(x);
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