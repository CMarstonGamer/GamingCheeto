using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();

        public clsStockCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStock Game = new clsStock();

                Game.productId = Convert.ToInt32(DB.DataTable.Rows[Index]["productId"]);
                Game.GameTitle = Convert.ToString(DB.DataTable.Rows[Index]["GameTitle"]);
                Game.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price(£)"]);
                Game.Platform = Convert.ToString(DB.DataTable.Rows[Index]["Platform"]);
                Game.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                Game.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                Game.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);

                mStockList.Add(Game);

                Index++;
            }
        }

        public clsStock ThisCustomer { get; set; }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }
    }

}
