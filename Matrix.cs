using System;

namespace PR_1 {
    public class Matrix {
        private int x_length_ = 4;
        private int y_length_ = 5;
        private int[,] matrix;

        public int x_length {
            get { return x_length_; }
        }

        public int y_length {
            get { return y_length_; }
        }

        public int this[int i, int j] {
            get {
                if (i <= 0 && j <= 0 && i > x_length && j > y_length)
                    throw new IndexOutOfRangeException("Вихід за межі масиву!");
                return matrix[i, j];
            }
            set {
                if (i <= 0 && j <= 0 && i > x_length && j > y_length)
                    throw new IndexOutOfRangeException("Вихід за межі масиву!");
                matrix[i, j] = value;
            }
        }

        public Matrix(int aLength, int bLength) {
            if (aLength <= 0 || bLength <= 0)
                throw new IndexOutOfRangeException("Масив менше 0 елементів!");
            x_length_ = aLength;
            y_length_ = bLength;
            matrix = new int[x_length_, y_length_];

            Random random = new Random();
            for (int i = 0; i < x_length; i++)
            for (int j = 0; j < y_length; j++)
                matrix[i, j] = random.Next(1, 100);
        }

        public (int, int) Min_ {
            get {
                var minSum = int.MaxValue;
                var minIndex = -1;

                for (var i = 0; i < x_length_; i++) {
                    var sum = 0;
                    for (var j = 0; j < y_length_; j++) {
                        sum += matrix[i, j];
                    }

                    if (sum >= minSum) continue;
                    minSum = sum;
                    minIndex = i;
                }

                return (minSum, minIndex + 1);
            }
        }
    }
}