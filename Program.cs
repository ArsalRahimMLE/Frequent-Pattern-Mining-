using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

     // static  List<string> frequentItems = new List<string>();

        static void Main(string[] args)
        {

          Algorithm algo = new Algorithm();
          BrandBasedPackage bbp = new BrandBasedPackage();
          bbp.createPackage(algo);
          Console.WriteLine("=====================================");
          CatagoryBasedPackage cbp = new CatagoryBasedPackage();
          cbp.createPackage(algo);
        }


       
    }
 }