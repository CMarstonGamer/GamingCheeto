﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mProductId;
        public int productId
        {
            get
            {
                return mProductId;
            }

            set
            {
                mProductId = value;
            }
        }

        private String mGameTitle;
        public string GameTitle
        {
            get
            {
                return mGameTitle;
            }

            set
            {
                mGameTitle = value;
            }
        }

        private Int32 mPrice;
        public int Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        private String mPlatform;
        public String Platform
        {
            get
            {
                return mPlatform;
            }

            set
            {
                mPlatform = value;
            }
        }

        private Boolean mInStock;
        public Boolean InStock
        {
            get
            {
                return mInStock;
            }

            set
            {
                mInStock = value;
            }
        }

        private Int32 mStockQuantity;
        public int StockQuantity
        {
            get
            {
                return mStockQuantity;
            }

            set
            {
                mStockQuantity = value;
            }
        }

        private DateTime mReleaseDate;
        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }

            set
            {
                mReleaseDate = value;
            }
        }

        public bool Find(int productId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@productId", productId);
            DB.Execute("sproc_tblStock_SelectId");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["productId"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price(£)"]);
                mPlatform = Convert.ToString(DB.DataTable.Rows[0]["Platform"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                return true;
            }
            else { return false; }
        }

        public string Valid(string GameTitle, string Price, string Platform, string StockQuantity, string ReleaseDate)
        {
            String Error = "";
            int PriceInt;
            int StockQuantityInt;
            DateTime ReleaseDateTemp;
            String MinDate = "01/01/1970";
            DateTime mMinDate = Convert.ToDateTime(MinDate);

            //Validate Game title
            if (GameTitle.Length == 0) //Extreme Min
            {
                Error = Error + "Game title must be more than 0 characters and less than 100";
            }

            if (GameTitle.Length > 100) //Extreme Min
            {
                Error = Error + "Game title must be more than 0 characters and less than 100";
            }


            //Validate price
            try
            {
                PriceInt = Convert.ToInt32(Price);
                if (PriceInt < 1)
                {
                    Error = Error + "Price must be more than 0";
                }

                if (PriceInt > 1000)
                {
                    Error = Error + "Price must be less than 1000";
                }
            }
            catch
            {
                Error = Error + "The price does not have a valid data type";
            }

            //validate StockQuantity
            try
            {
                StockQuantityInt = Convert.ToInt32(StockQuantity);
                if (StockQuantityInt < 0)
                {
                    Error = Error + "StockQuantity must be more than 0";
                }

                if (StockQuantityInt > 1000)
                {
                    Error = Error + "StockQuantity must be less than 1000";
                }

            }
            catch
            {
                Error = Error + "StockQuantity is not a valid data type";
            }

            //validate ReleaseDate
            try
            {
                ReleaseDateTemp = Convert.ToDateTime(ReleaseDate);
                if (ReleaseDateTemp < mMinDate)
                {
                    Error = Error + "Date must not be before 1970";
                }

                if (ReleaseDateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Date must not be in the future";
                }
            }
            catch
            {
                Error = Error + "ReleaseDate is wrong data type";
            }



            return Error;
        }

        
    }
}
