using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CatagoryBasedPackage
    {

        string[] catagory = new string[] { "food" , "cosmetic" , "garment" , "grocery" , "crokery" , "toy" , "electronic" , "medical" };
        Algorithm algo;
        List<string> finalpkg = new List<string>();
        public void createPackage(Algorithm algo)
        {
            this.algo = algo;
            for (int i = 0; i < DataCenter.ExpItemArr.Length; i++)
            {
                for (int j = 0; j <= DataCenter.productncatagory.GetUpperBound(0); j++)
                {
                    if (DataCenter.ExpItemArr[i] == DataCenter.productncatagory[j, 0])
                    {
                        mix(DataCenter.productncatagory[j, 1], i);
                    }
                }
            }
           // algo = new Algorithm();

            for (int i = 0; i < finalpkg.Count; i++)
            {
                Console.WriteLine(finalpkg[i]);
            }
            Console.WriteLine("===============================================");

        }

        public void mix(string ctgry, int ExpItemIndex)
        {

            for (int i = 0; i < algo.frequentItems.Count; i++)
            {
                for (int j = 0; j < DataCenter.productncatagory.GetUpperBound(0); j++)
                {                   //j < algo.frequentItems.Count
                    if (DataCenter.productncatagory[j, 0] == algo.frequentItems[i] && ctgry == DataCenter.productncatagory[j, 1])
                    {
                        finalpkg.Add(DataCenter.ExpItemArr[ExpItemIndex] + " " + algo.frequentItems[i]);
                    }
                }
            }

        }

    }
}
