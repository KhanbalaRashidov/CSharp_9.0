using System;

namespace Class_Math_Covert_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert class
            //byte
            //sbyte
            //int
            //char
            //bool
            //double
            //long
            //float
            //decimal
            //DateTime
            //uint
            //short
            //ushort
            //ulong
            //string

            //int i = Convert.ToByte("30");
            //byte j = byte.Parse("30");
            //Console.WriteLine($"i={i}  j={j}");

            //j = 0;
            ////j=int.Parse("2021"); //error
            //j = (byte)int.Parse("2021");
            //Console.WriteLine($"{j}");

            //i = Convert.ToByte(16.9);
            //Console.WriteLine($"i={i}");
            //j = Convert.ToByte(9.16);
            //Console.WriteLine($"j={j}");

            //i = Convert.ToByte(16.9f);
            //Console.WriteLine($"i={i}");
            //j = Convert.ToByte(9.16f);
            //Console.WriteLine($"j={j}");

            //i = Convert.ToByte(16.9m);
            //Console.WriteLine($"i={i}");
            //j = Convert.ToByte(9.16m);
            //Console.WriteLine($"j={j}");

            #endregion

            #region Math class
            //Console.WriteLine($"Area of the circle: {Math.PI*2*2:F3}");
            ////constant PI E
            //Console.WriteLine($"Math.PI={Math.PI}");  //3.14....
            //Console.WriteLine($"Math.E={Math.E}");    //2.71....

            ////Math.Exp
            //Console.WriteLine($"Math.Exp(2)={Math.Exp(2)}"); //e^2

            ////Math.Abs
            //Console.WriteLine($"|-1|={Math.Abs(-1)}  |1|={Math.Abs(1)}");

            ////Math.Pow
            //Console.WriteLine($"4^2={Math.Pow(4,2)}");

            ////Math.Sin Math.Cos Math.Tan ...
            //Console.WriteLine($"sin(PI/6)={Math.Sin(Math.PI/6)}  cos(30)={Math.Cos(Math.PI / 6)} tan(30)={Math.Tan(Math.PI / 6)}");
            //Console.WriteLine($"arcsin(1)={Math.Asin(1)} arccos(1)={Math.Acos(1)}  arctan(1)={Math.Atan(1)}");

            ////Math.Ceiling
            //Console.WriteLine(Math.Ceiling(1.4)); //2
            //Console.WriteLine(Math.Ceiling(-1.4)); //-1

            ////Math.Floor
            //Console.WriteLine(Math.Floor(1.4));  //1
            //Console.WriteLine(Math.Floor(-1.4)); //-2

            ////Math.Round
            //Console.WriteLine(Math.Round(1.4)); //1
            //Console.WriteLine(Math.Round(1.6)); //2
            //Console.WriteLine(Math.Round(-1.6)); //-2
            //Console.WriteLine(Math.Round(1.567865,3)); //1.568

            ////Math.Sign
            //Console.WriteLine(Math.Sign(14)); //1
            //Console.WriteLine(Math.Sign(-14)); //-1
            //Console.WriteLine(Math.Sign(0));

            //int r = 14;
            //double s = Math.PI * Math.Pow(r, 2);
            //Console.WriteLine($"s={s:F2}");

            #endregion

            #region DateTime TimeSpan
            DateTime date = new DateTime(2021, 1, 16, 01, 30, 50);
            Console.WriteLine(date);
            Console.WriteLine($"date.Year={date.Year}");
            Console.WriteLine($"date.Month={date.Month}");
            Console.WriteLine($"date.Day={date.Day}");
            Console.WriteLine($"date.Hour={date.Hour}");
            Console.WriteLine($"date.Minute={date.Minute}");
            Console.WriteLine($"date.Second={date.Second}");
            Console.WriteLine($"date.Millisecond={date.Millisecond}");

            //date.Add
            Console.WriteLine($"date.AddYears={date.AddYears(1)}");
            Console.WriteLine($"date.AddMonths={date.AddMonths(1)}");
            Console.WriteLine($"date.AddDays={date.AddDays(1)}");
            Console.WriteLine($"date.AddHours={date.AddHours(1)}");
            Console.WriteLine($"date.AddMinutes={date.AddMinutes(1)}");
            Console.WriteLine($"date.AddSeconds={date.AddSeconds(1)}");
            Console.WriteLine($"date.AddMilliseconds={date.AddMilliseconds(120)}");

            Console.WriteLine($"DateTime.Now={DateTime.Now}");

            DateTime newDate = date.AddYears(1).AddMonths(1).AddDays(1);
            Console.WriteLine($"newDate={newDate}");

            //TimeSpan
            TimeSpan span = newDate - date;
            Console.WriteLine($"span={span}");
            Console.WriteLine($"span.TotalDays={span.TotalDays} day");
            Console.WriteLine($"span.TotalHours={span.TotalHours} hour");
            Console.WriteLine($"span.TotalMinutes={span.TotalMinutes} minute");
            Console.WriteLine($"span.TotalSeconds={span.TotalSeconds} second");
            Console.WriteLine($"span.TotalMilliseconds={span.TotalMilliseconds} millisecond");

            Console.ReadKey();
            Console.Clear();

            date = DateTime.Now;
            double sum = 0;
            for (int i = 0; i < 2_000_000; i++)
            {
                sum += i;
            }

            Console.WriteLine($"sum={sum}");

            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timespan.TotalMilliseconds={timeSpan.TotalMilliseconds} millisecond");

            #endregion

        }
    }
}
