using System;

        public class Addition
        {

            private int a = 2;
            private int b = 3;
            public int Add()
            {

                return a + b;

            }

            static void Main()
            {
                Addition obj = new Addition();
                int sum = obj.Add();
                Console.WriteLine($"Summen er: {sum}");
                Console.ReadLine();
            }

        }



