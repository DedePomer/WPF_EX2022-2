using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EX2022
{
    public partial class BookMarket
    {

        #region Proprty
        public string TitleGener
        {
            get
            {
                return Title + " | " + Genre;
            }
        }

        public string StockCount
        {
            get
            {
                return Count(CountInStock);
            }
        }

        public string MarketCount
        {
            get
            {
                return Count(CountInMarket);
            }
        }

        public string Img
        {
            get
            {
                return "\\" + Image;
            }
        }

        public string SubDiscription
        {
            get
            {
                return Discription;
            }
        }
        #endregion

        #region Methods
        public string Count(int count)
        {
            if (count == 0)
            {
                return "нет";
            }
            if (count > 5)
            {
                return "много";
            }
            else
            {
                return "" + count;
            }
            return "";
        }
        #endregion
    }
}
