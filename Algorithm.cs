using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Algorithm
    {

       public List<string> frequentItems = new List<string>();
       
        public Algorithm()
        {
            

            //string[][] transactionArray = new string[7][] { { "ab", "as", "fg", "we" }, { "we", "tr", "yt", "lo" }, { "fd", "gf", "we", "ab" }, { "bc", "mc", "ny", "ab" }, { "ab", "as", "bc", "lo" }, { "po", "mc", "ny", "ab" }, { "gh", "gf", "ny", "we" } };
            //int bound0 = transactionArray.GetUpperBound(0);
            //int bound1 = transactionArray.GetUpperBound(1);

            //for (int i = 0; i <= bound0; i++)
            //{
            //    for (int j = 0; j <= bound1; i++)
            //    {
            //        Console.WriteLine(transactionArray[i,j]);
            //    }
            //}
          //  List<string> frequentItems = new List<string>();
            string[][] arr = new string[3][];
            arr[0] = new string[4] { "ab", "ad", "at", "aq", };
            arr[1] = new string[4] { "ib", "yb", "ar", "aw", };
            arr[2] = new string[4] { "af", "ah", "aj", "al", };
            //arr[0] = new string[4] { "ab", "as", "fg", "we" };
            //arr[1] = new string[2] { "we", "tr" };
            //arr[2] = new string[3] { "ab", "fg", "we" };
            //arr[3] = new string[3] { "tr", "cv", "we" };
            //arr[4] = new string[5] { "ab", "fg", "as", "gh", "cv" };
            //arr[5] = new string[3] { "tr", "cv", "as" };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (!frequentItems.Contains(arr[i][j])) //aggr arr[i,j] exixts na krta ho list(frequentItems) main tw list main add krdo value arr[i,j]
                    { //if (arr[i][j] !=  frequentItems[j])

                        frequentItems.Add(arr[i][j]);
                    }
                }
            }


            //TESTING OUTPUT
            for (int i = 0; i < frequentItems.Count; i++)
            {
                Console.WriteLine(frequentItems[i]);
            }
            Console.WriteLine("===============================================");

            #region
            //calculating the count of frequentItems in each transaction

            int[] itemsCount = new int[frequentItems.Count];
            for (int k = 0; k < frequentItems.Count; k++)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (frequentItems[k] == arr[i][j])
                        {
                            count++;
                        }
                    }
                }
                itemsCount[k] = count;
            }
            #endregion 

            //TESTING OUTPUT
            for (int i = 0; i < itemsCount.Length; i++)
            {
                Console.WriteLine(itemsCount[i]);
            }
            Console.WriteLine("===============================================");

            #region
            //taking avgerage of the count 
            int sum = 0;
            for (int i = 0; i < itemsCount.Length; i++)
            {
                sum = sum + itemsCount[i];
            }
            int average = sum / itemsCount.Length; // check sealing or flouring properly in average
            #endregion

            Console.WriteLine("average " + average);
            //swaping mthd and some code for rmoving those frequentItems from the frequentItems count 
            // bhai aggr koi bhi value choti ho average se itemcount array ke andr tw usse pick kre or jo frequentItems ki list hai "frequentItems" ke naam se uss mian se woh item remove ho jae, bcz itemcount or "frequentItems" list aik dosre se interlinked hain (in terms of indexes)
            List<int> itmcountlist = itemsCount.ToList<int>();
           // int counter = 0;
            for (int i = 0; i < itmcountlist.Count; i++)
            {
                if (itmcountlist[i] <= average)
                {
                    //swap(i, itemsCount);
                    
                    frequentItems.RemoveAt(i);
                    itmcountlist.RemoveAt(i);
                    i--;
                   // counter++;
                }
            }

            //int[] temp = itemsCount;
            //itemsCount = new int[temp.Length - counter];
            //for (int i = 0; i < temp.Length - counter; i++)
            //{
            //    itemsCount[i] = temp[i];
            //}
            for (int i = 0; i < frequentItems.Count; i++)
            {
                Console.WriteLine(frequentItems[i]);
            }
            Console.WriteLine("===============================================");
            for (int i = 0; i < itmcountlist.Count; i++)
            {
                Console.WriteLine(itmcountlist[i]);
            }
            Console.WriteLine("===============================================");

        }

        //Swapping Method
        public void swap(int indexToSwap, int[] temp)
        {

            for (int i = indexToSwap; i < temp.Length - 1; i++)
            {
                temp[i] = temp[i + 1];
            }

        }

    }
}
