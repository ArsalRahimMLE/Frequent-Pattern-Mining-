using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BrandBasedPackage
    {

        string[] brand = new string[] { "shan", "unilivers", "kolson", "national", "sasso", "adidas", "shangrila", "reckitt benckiser", "saathi", "nike" };
        Algorithm algo;
        List<string> finalpkg = new List<string>();
        public void createPackage(Algorithm algo)
        {
            this.algo = algo;
            for (int i = 0; i < DataCenter.ExpItemArr.Length; i++)
            {
                for (int j = 0; j <= DataCenter.productnbrand.GetUpperBound(0); j++)
                {
                    if (DataCenter.ExpItemArr[i] == DataCenter.productnbrand[j, 0])
                    {
                        mix(DataCenter.productnbrand[j, 1],i);
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

        public void mix(string brnd, int ExpItemIndex)
        {

            for (int i = 0; i < algo.frequentItems.Count; i++)
            {
                    for (int j = 0; j < DataCenter.productnbrand.GetUpperBound(0); j++)
                    {                   //j < algo.frequentItems.Count
                        if (DataCenter.productnbrand[j, 0] == algo.frequentItems[i] && brnd == DataCenter.productnbrand[j, 1])
                        {
                            finalpkg.Add(DataCenter.ExpItemArr[ExpItemIndex] + " " + algo.frequentItems[i]);
                        }
                    }
            }

           //for (int i = 0; i < algo.frequentItems.Count; i++)
            //{

            //    if (brnd.Equals(DataCenter.productnbrand[i, 1]))
            //    {

            //        for (int j = 0; j <= DataCenter.productnbrand.GetUpperBound(0); j++)
            //        {                   //j < algo.frequentItems.Count
            //            if (DataCenter.productnbrand[j, 0] == algo.frequentItems[i])
            //            {
            //                finalpkg.Add(DataCenter.ExpItemArr[ExpItemIndex] + " " + algo.frequentItems[i]);
            //            }
            //        }

            //    }
            //}

        }

    }
}
