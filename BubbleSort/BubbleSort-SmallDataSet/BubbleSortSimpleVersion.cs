using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_SmallDataSet
    {
    class BubbleSortSimpleVersion
        {
        public static void BubbleSortSmallDataSet ()
            {
            //Implementation
            int[] number = { 89, 76, 45, 92, 67, 12, 99, 4, 55, 12 };
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //Before Sorting
            //Sorted array
            Console.WriteLine("***Before Sorting***");
            foreach ( int num in number )
                {
                Console.WriteLine("\t" + num);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //sorting an array
            for ( int i = 1; (i <= (numLength - 1)) && flag; i++ )
                {
                flag = false;
                for ( int j = 0; j < (numLength - 1); j++ )
                    {
                    if ( number[j + 1] > number[j] )
                        {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                        }
                    }
                }
            //Sorted array
            Console.WriteLine("***After Sorting***");
            foreach ( int numb in number )
                {
                Console.WriteLine("\t" + numb);
                }
            var endtime = watch.Elapsed;
            Console.WriteLine("Start Time: " + starttime);
            Console.WriteLine("End Time: " + endtime);
            watch.Stop();
            Console.WriteLine("Elapsed Time: " + endtime.Subtract(starttime));
            var elapsedTicks = watch.ElapsedTicks;
            Console.WriteLine("Elapsed Time in Ticks: " + elapsedTicks);
            Console.Read();
            }
        public static void BubbleSortMediumDataSet ()
            {
            //Implementation
            Random random = new Random();
            int[] number = new int[1000];
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //Before Sorting
            //Sorted array
            Console.WriteLine("***Before Sorting***");
            for ( int i = 0; i < 1000; i++ )
                {
                number[i] = random.Next(0, 1000);
                Console.WriteLine("\t" + number[i]);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //sorting an array
            for ( int i = 1; (i <= (numLength - 1)) && flag; i++ )
                {
                flag = false;
                for ( int j = 0; j < (numLength - 1); j++ )
                    {
                    if ( number[j + 1] > number[j] )
                        {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                        }
                    }
                }
            //Sorted array
            Console.WriteLine("***After Sorting***");
            foreach ( int num in number )
                {
                Console.WriteLine("\t" + num);
                }

            var endtime = watch.Elapsed;
            Console.WriteLine("Start Time: " + starttime);
            Console.WriteLine("End Time: " + endtime);
            watch.Stop();
            Console.WriteLine("Elapsed Time: " + endtime.Subtract(starttime));
            var elapsedTicks = watch.ElapsedTicks;
            Console.WriteLine("Elapsed Time in Ticks: " + elapsedTicks);
            Console.Read();
            }
        public static void BubbleSortLargeDataSet ()
            {
            //Implementation
            Random random = new Random();
            int[] number = new int[10000];
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //Before Sorting
            //Sorted array
            Console.WriteLine("***Before Sorting***");
            for ( int i = 0; i < 10000; i++ )
                {
                number[i] = random.Next(0, 10000);
                Console.WriteLine("\t" + number[i]);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //sorting an array
            for ( int i = 1; (i <= (numLength - 1)) && flag; i++ )
                {
                flag = false;
                for ( int j = 0; j < (numLength - 1); j++ )
                    {
                    if ( number[j + 1] > number[j] )
                        {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                        }
                    }
                }
            //Sorted array
            Console.WriteLine("***After Sorting***");
            foreach ( int num in number )
                {
                Console.WriteLine("\t" + num);
                }

            var endtime = watch.Elapsed;
            Console.WriteLine("Start Time: " + starttime);
            Console.WriteLine("End Time: " + endtime);
            watch.Stop();
            Console.WriteLine("Elapsed Time: " + endtime.Subtract(starttime));
            var elapsedTicks = watch.ElapsedTicks;
            Console.WriteLine("Elapsed Time in Ticks: " + elapsedTicks);
            Console.Read();
            }
        }
    }
