using System;

namespace PR_1 {
    internal class Array {
        private int[] array;

        public int Length {
            get {
                return length;
            } 
        }

        private int length = 15;

        public int this[int i] {
            get {
                if (i >= 0 && i < length)
                    return array[i];
                else
                    throw new IndexOutOfRangeException("Вихід за межі масиву!");
            }

            set {
                if (!(value >= -100 && value < 100))
                    throw new ArgumentOutOfRangeException("Число вийшло за рамки [-100, 100]!");
                if (i >= 0 && i < length)
                    array[i] = value;
                else
                    throw new IndexOutOfRangeException("Вихід за межі масиву!");
            }
        }

        public Array() {
            array = new int[length];
        }

        public Array(int[] array) {
            this.array = array;
        }

        public Array(int size) {
            if (size <= 0)
                throw new IndexOutOfRangeException("Масив не може бути менше 0 елементів!");
            length = size;
            array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
                array[i] = rand.Next(-50, 50);
        }

        public int Min {
            get {
                var min = array[0];
                foreach (var element in array) {
                    if (element < min)
                        min = element;
                }

                return min;
            }
        }
    }
}