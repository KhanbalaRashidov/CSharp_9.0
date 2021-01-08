using System;

namespace Lesson_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---Array--->");

            int[] x;
            x = new int[5];
            x[0] = 1;
            x[1] = 2;
            x[2] = 3;
            x[3] = 4;
            x[4] = 5;

            int[] y = new[] {1,2,3,4,5 };
            int[] z = { 1, 2, 3, 4, 5 };
            int[] k = new int[5] {1,2,3,4,5 };

            double[] array = { 10, 10.5, 20, 20.5 };

            string[] names = { "Khanbala", "Mushfiq","Orxan","Qismet","Elvan","Ferhad","Yalchin","Sadiq" };

            Console.WriteLine($"x[0]={x[0]} y[0]={y[0]} z[0]={z[0]} k[0]={k[0]} array[0]={array[0]} names[0]={names[0]}");
        }
    }
}
