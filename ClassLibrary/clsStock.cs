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
    }
}
