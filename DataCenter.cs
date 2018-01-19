using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public static class DataCenter
    {

       public static string[] ExpItemArr = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz" };
       public static string[,] productnbrand = new string[,] { {"abc","saathi"} , {"def", "shan"} , {"ghi", "unilivers" }, { "jkl", "national" }, { "mno" , "reckitt benckiser" }, { "pqr", "sasso" }, { "stu", "adidas" }, { "vwx", "shangrila" }, { "yz", "nike" },
          {"we","saathi"}, {"tr","reckitt benckiser"}, {"fg","reckitt benckiser"} , {"ab","shan"}, {"as","unilivers"}, {"cv","national"} , {"gh","sasso"} };
       public static string[,] productncatagory = new string[,] { {"abc","toy"} , {"def", "cosmetic"} , {"ghi", "grocery" }, { "jkl", "crokery" }, { "mno" , "medical" }, { "pqr", "garment" }, { "stu", "food" }, { "vwx", "garment" }, { "yz", "medical" },
          {"we","toy"}, {"tr","food"}, {"fg","toy"} , {"ab","crokery"}, {"as","garment"}, {"cv","food"} , {"gh","cosmetic"} };
    }
}
