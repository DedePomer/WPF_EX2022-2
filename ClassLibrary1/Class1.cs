using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleLibrary
{
    public class Class1
    {
        static int OurSale = 0;

        public static int SaleCalc(int CountBook, float Coast)
        {
            if (CountBook<=0)
            {
                OurSale = 0;
            }
            else if (CountBook >= 3 && CountBook < 5)
            {
                OurSale = 5;
            }
            else if (CountBook >= 5 && CountBook < 10)
            {
                OurSale = 10;
            }
            else if (CountBook >= 10)
            {
                OurSale = 15;
            }
            int CountSale = 0;
            if (Coast < 0)
            {
                return OurSale;
            }
            else
            {
                CountSale = (int)Coast / 500;
            }           
            return OurSale + CountSale; 
        }
    }
}
