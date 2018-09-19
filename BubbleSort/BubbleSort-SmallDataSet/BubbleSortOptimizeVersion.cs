using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_SmallDataSet
    {
    class BubbleSortOptimizeVersion
        {
        public static void BubbleSortSmallDataset ()
            {
            int[] number = { 89, 76, 45, 92, 67, 12, 99, 4, 55, 12 };
            //Initial array size.keep decreasing this value based on the last swap we encounter.
            int n = 10;
            Console.WriteLine("***Before Sorting***");
            foreach ( int num in number )
                {
                Console.WriteLine("\t" + num);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //Keep looping until list is sorted
            do
                {    
                //This variable is used to store the position of the last swap
                int sw = 0;

                //Loop through all elements in the list
                for ( int i = 0; i < n - 1; i++ )
                    {
                    //If the current pair of elements is not in order then swap them and update the position of the swap 
                    if ( number[i] > number[i + 1] )
                        {
                        //Swap
                        int temp = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = temp;

                        //Save swap position
                        sw = i + 1;
                        }
                    }

                //I do not need to visit all elements. I only need to go as far as the last swap. so update (n)
                n = sw;
                }

            //Once n = 1 then the whole list is sorted
            while ( n > 1 );
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
            Random random = new Random();
            int[] number = new int[1000];
            //Initial array size.keep decreasing this value based on the last swap we encounter.
            int n = 10;
            Console.WriteLine("***Before Sorting***");
            for ( int i = 0; i < 1000; i++ )
                {
                number[i] = random.Next(0, 1000);
                Console.WriteLine("\t" + number[i]);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //Keep looping until list is sorted
            do
                {
                //This variable is used to store the position of the last swap
                int sw = 0;

                //Loop through all elements in the list
                for ( int i = 0; i < n - 1; i++ )
                    {
                    //If the current pair of elements is not in order then swap them and update the position of the swap 
                    if ( number[i] > number[i + 1] )
                        {
                        //Swap
                        int temp = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = temp;

                        //Save swap position
                        sw = i + 1;
                        }
                    }

                //I do not need to visit all elements. I only need to go as far as the last swap. so update (n)
                n = sw;
                }

            //Once n = 1 then the whole list is sorted
            while ( n > 1 );
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
            Random random = new Random();
            int[] number = new int[10000];
            //Initial array size.keep decreasing this value based on the last swap we encounter.
            int n = 10;
            Console.WriteLine("***Before Sorting***");
            for ( int i = 0; i < 10000; i++ )
                {
                number[i] = random.Next(0, 10000);
                Console.WriteLine("\t" + number[i]);
                }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var starttime = watch.Elapsed;
            //Keep looping until list is sorted
            do
                {
                //This variable is used to store the position of the last swap
                int sw = 0;

                //Loop through all elements in the list
                for ( int i = 0; i < n - 1; i++ )
                    {
                    //If the current pair of elements is not in order then swap them and update the position of the swap 
                    if ( number[i] > number[i + 1] )
                        {
                        //Swap
                        int temp = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = temp;

                        //Save swap position
                        sw = i + 1;
                        }
                    }

                //I do not need to visit all elements. I only need to go as far as the last swap. so update (n)
                n = sw;
                }

            //Once n = 1 then the whole list is sorted
            while ( n > 1 );
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
