using System;

namespace Basic_DataType_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            {
                //byte --> int and uint
                {
                    //byte --> int
                    {
                        byte num1 = 3;
                        Console.WriteLine(num1);
                        int numShort = num1 + 1;
                        Console.WriteLine(numShort);
                    }
                    //byte --> uint
                    {
                        byte num1 = 3;
                        Console.WriteLine(num1);
                        uint num2 = num1;
                        Console.WriteLine(num2);
                    }
                }
                //byte --> byte
                {
                    byte num1 = 4;
                    Console.WriteLine(num1);
                    //byte num2 = num1 + 5; //error
                    byte num2 = (byte)(num1 + 10);
                    Console.WriteLine(num2);
                }
                //byte --> short and ushort
                {
                    //byte --> short
                    {
                        byte num1 = 3;
                        Console.WriteLine(num1);
                        short num2 = num1;
                        Console.WriteLine(num2);
                    }
                    //byte --> ushort
                    {

                        byte num1 = 3;
                        Console.WriteLine(num1);
                        ushort num2 = num1;
                        Console.WriteLine(num2);
                    }
                }
                //byte --> long and ulong
                {
                    //byte -->long 
                    {
                        byte num1 = 3;
                        Console.WriteLine(num1);
                        long num2 = num1 + 3;
                        Console.WriteLine(num2);
                    }
                    //byte --> ulong
                    {
                        byte num1 = 3;
                        Console.WriteLine(num1);
                        ulong num2 = num1;
                        Console.WriteLine(num2);
                    }
                }
                //byte --> double,float and decimal
                {
                    //byte --> double
                    byte num1 = 3;
                    Console.WriteLine(num1);
                    double num2 = num1;
                    Console.WriteLine(num2);
                }
                //byte --> float
                {
                    byte num1 = 3;
                    Console.WriteLine(num1);
                    float num2 = num1;
                    Console.WriteLine(num2);
                }
                //byte --> decimal
                {
                    byte num1 = 3;
                    Console.WriteLine(num1);
                    decimal num2 = num1;
                    Console.WriteLine(num2);
                }

            }
            //short and ushort
            {
                //short
                {
                    //short --> int and uint
                    {
                        //short --> int
                        {
                            short num1 = 3;
                            Console.WriteLine(num1);
                            int numShort = num1 + 1;
                            Console.WriteLine(numShort);
                        }
                        //short --> uint
                        {
                            short num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = (uint)num1;
                            Console.WriteLine(num2);
                        }
                    }
                    //short  --> byte
                    {
                        short num1 = 4;
                        Console.WriteLine(num1);
                        //byte num2 = num1 + 5; //error
                        byte num2 = (byte)(num1 + 10);
                        Console.WriteLine(num2);
                    }
                    //short -->short and  ushort
                    {
                        //short --> short
                        {
                            short num1 = 3;
                            // short num2 = num1 + 3;//error
                            short num2 = (short)(num1 + 3);

                        }
                        //short --> ushort
                        {

                            short num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)num1;
                            Console.WriteLine(num2);
                        }
                    }
                    //short --> long and ulong
                    {
                        //short -->long 
                        {
                            short num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //short --> ulong
                        {
                            short num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = (ulong)num1;
                            Console.WriteLine(num2);
                        }
                    }
                    //short --> double,float and decimal
                    {
                        //short --> double
                        short num1 = 3;
                        Console.WriteLine(num1);
                        double num2 = num1;
                        Console.WriteLine(num2);
                    }
                    //short --> float
                    {
                        short num1 = 3;
                        Console.WriteLine(num1);
                        float num2 = num1;
                        Console.WriteLine(num2);
                    }
                    //short --> decimal
                    {
                        short num1 = 3;
                        Console.WriteLine(num1);
                        decimal num2 = num1;
                        Console.WriteLine(num2);
                    }
                }
                //ushort
                {
                    //ushort --> int and uint
                    {
                        //ushort --> int
                        {
                            ushort num1 = 3;
                            Console.WriteLine(num1);
                            int numShort = num1 + 1;
                            Console.WriteLine(numShort);
                        }
                        //ushort --> uint
                        {
                            ushort num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = num1;
                            Console.WriteLine(num2);
                        }
                    }

                    //ushort -->short and  ushort
                    {
                        //ushort --> short
                        {
                            ushort num1 = 3;
                            short num2 = (short)num1;
                        }
                        //ushort --> ushort
                        {

                            ushort num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)(num1 + 1);
                            Console.WriteLine(num2);
                        }
                    }
                    //ushort --> long and ulong
                    {
                        //ushort -->long 
                        {
                            ushort num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //ushort --> ulong
                        {
                            ushort num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = num1;
                            Console.WriteLine(num2);
                        }
                    }
                    //ushort --> double,float and decimal
                    {
                        //ushort --> double
                        ushort num1 = 3;
                        Console.WriteLine(num1);
                        double num2 = num1;
                        Console.WriteLine(num2);
                    }
                    //ushort --> float
                    {
                        ushort num1 = 3;
                        Console.WriteLine(num1);
                        float num2 = num1;
                        Console.WriteLine(num2);
                    }
                    //ushort --> decimal
                    {
                        ushort num1 = 3;
                        Console.WriteLine(num1);
                        decimal num2 = num1;
                        Console.WriteLine(num2);
                    }
                }
            }
            //int and uint
            {
                //int
                {
                    //int --> int and uint
                    {
                        //int --> int
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            int num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //int --> uint
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = (uint)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //int --> byte and sbyte
                    {
                        //int --> byte
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            byte num2 = (byte)(num1);
                            Console.WriteLine(num2);
                        }
                        //int --> sbyte
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            sbyte num2 = (sbyte)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //int --> short and ushort
                    {
                        //int --> short
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            short num2 = (short)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //int --> ushort
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //int --> long and ulong
                    {
                        //int --> long 
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //int --> ulong 
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = (ulong)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //int --> double, float and decimal
                    {
                        //int --> double
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            double num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //int --> float
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            float num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //int --> decimal
                        {
                            int num1 = 3;
                            Console.WriteLine(num1);
                            decimal num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                }
                //uint
                {
                    //uint --> int and uint
                    {
                        //uint --> int
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            int num2 = (int)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //uint --> uint
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                    //uint --> byte and sbyte
                    {
                        //uint --> byte
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            byte num2 = (byte)(num1);
                            Console.WriteLine(num2);
                        }
                        //uint --> sbyte
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            sbyte num2 = (sbyte)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //uint --> short and ushort
                    {
                        //uint --> short
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            short num2 = (short)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //uint --> ushort
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //uint --> long and ulong
                    {
                        //uint --> long 
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //iunt --> ulong 
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                    //uint --> double, float and decimal
                    {
                        //uint --> double
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            double num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //uint --> float
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            float num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //uint --> decimal
                        {
                            uint num1 = 3;
                            Console.WriteLine(num1);
                            decimal num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                }
            }
            //-------------
            //long and ulong
            {
                //long
                {
                    //long --> int and uint
                    {
                        //long --> int
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            int num2 = (int)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //long --> uint
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = (uint)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //long --> byte and sbyte
                    {
                        //int --> byte
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            byte num2 = (byte)(num1);
                            Console.WriteLine(num2);
                        }
                        //long --> sbyte
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            sbyte num2 = (sbyte)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //long --> short and ushort
                    {
                        //long --> short
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            short num2 = (short)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //long --> ushort
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //long --> long and ulong
                    {
                        //long --> long 
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //long --> ulong 
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = (ulong)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //long --> double, float and decimal
                    {
                        //long --> double
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            double num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //long --> float
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            float num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //long --> decimal
                        {
                            long num1 = 3;
                            Console.WriteLine(num1);
                            decimal num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                }
                //ulong
                {
                    //ulong --> int and uint
                    {
                        //ulong --> int
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            int num2 = (int)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //ulong --> uint
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            uint num2 = (uint)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //ulong --> byte and sbyte
                    {
                        //ulong --> byte
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            byte num2 = (byte)(num1);
                            Console.WriteLine(num2);
                        }
                        //ulong --> sbyte
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            sbyte num2 = (sbyte)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //ulong --> short and ushort
                    {
                        //ulong --> short
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            short num2 = (short)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //ulong --> ushort
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            ushort num2 = (ushort)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                    }
                    //ulong --> long and ulong
                    {
                        //ulong --> long 
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            long num2 = (long)(num1 + 3);
                            Console.WriteLine(num2);
                        }
                        //ulong --> ulong 
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            ulong num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                    //ulong --> double, float and decimal
                    {
                        //ulong --> double
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            double num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //ulong --> float
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            float num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                        //uint --> decimal
                        {
                            ulong num1 = 3;
                            Console.WriteLine(num1);
                            decimal num2 = num1 + 3;
                            Console.WriteLine(num2);
                        }
                    }
                }
            }
            //double
            {
                //double --> byte and sbyte
                {
                    //double --> byte
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        byte num2 = (byte)(num1);
                        Console.WriteLine(num2);
                    }
                    //double -->sbyte
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        sbyte num2 = (sbyte)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //double --> short and ushort
                {
                    //double --> short
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        short num2 = (short)(num1);
                        Console.WriteLine(num2);
                    }
                    //double -->ushort
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        ushort num2 = (ushort)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //dpuble --> int and uint
                {
                    //double --> int
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        int num2 = (int)(num1);
                        Console.WriteLine(num2);
                    }
                    //double -->uint
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        uint num2 = (uint)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //double --> long and ulong
                {
                    //double --> long
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        long num2 = (long)(num1);
                        Console.WriteLine(num2);
                    }
                    //double -->ulong
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        ulong num2 = (ulong)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //double --> double, float and decimal
                {
                    //double --> double
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        double num2 = num1 + 3;
                        Console.WriteLine(num2);
                    }
                    //double --> float
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        float num2 = (float)(num1 + 3);
                        Console.WriteLine(num2);
                    }
                    //double --> decimal
                    {
                        double num1 = 3;
                        Console.WriteLine(num1);
                        decimal num2 = (decimal)(num1 + 3);
                        Console.WriteLine(num2);
                    }
                }
            }
            //float 
            {
                //float --> byte and sbyte
                {
                    //float --> byte
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        byte num2 = (byte)(num1);
                        Console.WriteLine(num2);
                    }
                    //float -->sbyte
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        sbyte num2 = (sbyte)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //float --> short and ushort
                {
                    //float --> short
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        short num2 = (short)(num1);
                        Console.WriteLine(num2);
                    }
                    //float -->ushort
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        ushort num2 = (ushort)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //float --> int and uint
                {
                    //float --> int
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        int num2 = (int)(num1);
                        Console.WriteLine(num2);
                    }
                    //float -->uint
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        uint num2 = (uint)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //float --> long and ulong
                {
                    //float --> long
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        long num2 = (long)(num1);
                        Console.WriteLine(num2);
                    }
                    //float -->ulong
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        ulong num2 = (ulong)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //float --> double, float and decimal
                {
                    //float --> double
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        double num2 = num1 + 3;
                        Console.WriteLine(num2);
                    }
                    //float --> float
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        float num2 = num1 + 3;
                        Console.WriteLine(num2);
                    }
                    //float --> decimal
                    {
                        float num1 = 3;
                        Console.WriteLine(num1);
                        decimal num2 = (decimal)(num1 + 3);
                        Console.WriteLine(num2);
                    }
                }
            }
            //decimal
            {
                //decimal --> byte and sbyte
                {
                    //decimal --> byte
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        byte num2 = (byte)(num1);
                        Console.WriteLine(num2);
                    }
                    //decimal -->sbyte
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        sbyte num2 = (sbyte)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //decimal --> short and ushort
                {
                    //decimal --> short
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        short num2 = (short)(num1);
                        Console.WriteLine(num2);
                    }
                    //decimal -->ushort
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        ushort num2 = (ushort)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //decimal --> int and uint
                {
                    //decimal --> int
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        int num2 = (int)(num1);
                        Console.WriteLine(num2);
                    }
                    //decimal -->uint
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        uint num2 = (uint)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //decimal --> long and ulong
                {
                    //decimal --> long
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        long num2 = (long)(num1);
                        Console.WriteLine(num2);
                    }
                    //decimal -->ulong
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        ulong num2 = (ulong)(num1);
                        Console.WriteLine(num2);
                    }
                }
                //decimal --> double, float and decimal
                {
                    //decimal --> double
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        double num2 = (double)(num1 + 3);
                        Console.WriteLine(num2);
                    }
                    //decimal --> float
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        float num2 = (float)(num1 + 3);
                        Console.WriteLine(num2);
                    }
                    //double --> decimal
                    {
                        decimal num1 = 3;
                        Console.WriteLine(num1);
                        decimal num2 = num1 + 3;
                        Console.WriteLine(num2);
                    }
                }
            }
            //char
            {
                //char --byte and sbyte
                {
                    //char --> byte 
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        byte num1 = (byte)(ch);
                        Console.WriteLine(num1);
                    }
                    //char --> sbyte
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        sbyte num1 = (sbyte)(ch);
                        Console.WriteLine(num1);
                    }
                }
                //char --> short and ushort
                {
                    //char --> short
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        short num1 =(short)(ch);
                        Console.WriteLine(num1);
                    }
                    //char --> ushort
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        ushort num1 = ch;
                        Console.WriteLine(num1);
                    }
                }
                //char --> int and uint
                {
                    //char --> int
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        int num1 = ch;
                        Console.WriteLine(num1);
                    }
                    //char --> uint
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        uint num1 = ch;
                        Console.WriteLine(num1);
                    }
                }
                //char --> long and ulong
                {
                    //char --> long
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        long num1 = ch;
                        Console.WriteLine(num1);
                    }
                    //char --> ulong
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        ulong num1 = ch;
                        Console.WriteLine(num1);
                    }
                }
                //char --> double, float and decimal
                {
                    //char --> double 
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        double num1 = ch;
                        Console.WriteLine(num1);
                    }
                    //char --> float
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        float num1 = ch;
                        Console.WriteLine(num1);
                    }
                    //char --> decimal
                    {
                        char ch = 'X';
                        Console.WriteLine(ch);
                        decimal num1 = ch;
                        Console.WriteLine(num1);
                    }
                }
            }



            //Narrowing and widening transformations
            {
                //widening
                {
                    byte a = 4;             // 0000100
                    ushort b = a;          // 000000000000100
                }
                //narrowing
                {
                    ushort a = 4;        // 000000000000100
                    byte b = (byte)(a); //0000100
                }
            }

            //key checked
            {
                {
                    int a = 33;
                    int b = 600;
                    byte c = (byte)(a + b);
                    Console.WriteLine($"c={c}");
                }
                try
                {
                    int a = 33;
                    int b = 600;
                    byte c = checked((byte)(a + b));
                    Console.WriteLine(c);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            {
                float num1 = 10f;
                Console.WriteLine(num1);
                Console.WriteLine(1.65.GetType());
                int num2 = (int)num1;
                Console.WriteLine(num2);
            }
            {
                Console.WriteLine((int)('y'));
                Console.WriteLine(3 * 'e');
                Console.WriteLine((int)('p'));
                var sum = 'y' + 3 * 'e' + 'p';
                Console.WriteLine($"sum={sum}");
            }
            {
                int a = 257;
                byte b =unchecked((byte)a);
                Console.WriteLine(b);
            }
            //Parse conversion
            {
               /* string StrNum = "2021";
                int num = StrNum; //error CS0029
               */
                string StrNum = "2021";
                int a = int.Parse(StrNum);
                Console.WriteLine(a);
             
                double b = double.Parse(StrNum);
                Console.WriteLine(b);

                uint c = uint.Parse(StrNum);
                Console.WriteLine(c);
               // byte d =unchecked( byte.Parse(StrNum)); // overflow exception
                string strNum = "255";
                byte d = byte.Parse(strNum);
                Console.WriteLine(d);
            }
            //Convert conversion
            {
                string strNumber = "2021";
                int intValue = Convert.ToInt32(strNumber);
                Console.WriteLine(intValue);

                double doubleValue = Convert.ToDouble(strNumber);
                Console.WriteLine(doubleValue);

                uint uintValue = Convert.ToUInt32(strNumber);
                Console.WriteLine(uintValue);
              /* 
                byte byteValue = Convert.ToByte(strNumber); //Overflow exception
                Console.WriteLine(byteValue);
              */
            }
            Console.ReadKey();
        }
    }
}
