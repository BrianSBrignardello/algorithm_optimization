using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_SmallDataSet
    {
    class Program
        {
        static void Main (string[] args)
            {
            //Helping Material Reference:
            //https://www.c-sharpcorner.com/UploadFile/3d39b4/bubble-sort-in-C-Sharp/
            //Algorithm

            //Procedure BubbleSort(DATA: list of sortable items)
            //N = DATA.Length
            //1.Set Flag:= True
            //2.Repeat Steps from 3 to 5 for I = 1 to N - 1 while Flag == true
            //3.Set Flag:= False
            //4.Set J:= 0. [Initialize pass pointer J]
            //5.Repeat while J < N - 1[Executes pass]
            //(a)     If DATA[J + 1]> DATA[J], then:
            //            Swap DATA[J] and DATA[J + 1]
            //Set Flag:= True
            //[End of If structure]
            //(b)   Set J:= J + 1
            //[End of inner loop]
            //[End of step 1 outer loop]
            //6.Exit

            /******Bubble sort Simple Version*******/
            //Bubble sort with small data set that contains only 10 integers
            //Elapsed Time: 00:00:00.0004701
            BubbleSortSimpleVersion.BubbleSortSmallDataSet();


            //Bubble sort with medium data set that contains only 1000 Random integers ( In range of 1000)
            //Elapsed Time: 00:00:00.3981469
            BubbleSortSimpleVersion.BubbleSortMediumDataSet();


            //Bubble sort with large data set that contains only 10000 Random integers ( In range of 10000)
            //Elapsed Time: 00:00:00.9516341
            BubbleSortSimpleVersion.BubbleSortLargeDataSet();


            /******Bubble Sort optimize Version*******/
            //Bubble sort with small data set that contains only 10 integers
            //Elapsed Time: 00:00:00.0006714
            BubbleSortOptimizeVersion.BubbleSortSmallDataset();


            //Bubble sort with medium data set that contains only 1000 Random integers ( In range of 1000)
            //Elapsed Time: 00:00:00.3943288
            BubbleSortOptimizeVersion.BubbleSortMediumDataSet();


            //Bubble sort with large data set that contains only 10000 Random integers ( In range of 10000)
            //Elapsed Time: 00:00:00.4246417
            BubbleSortOptimizeVersion.BubbleSortLargeDataSet();



            //Note: As you observe, Difference is shown in optimize version when dataset getting larger,
            //on small dataset there is no big difference in Elasped Time but on larger data, difference
            //can be seen easily.
            }

        }
    }
