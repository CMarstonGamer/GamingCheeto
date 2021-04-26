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
        clsStock mThisGame = new clsStock();

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@Platform", mThisGame.Platform);
            DB.AddParameter("@StockQuantity", mThisGame.StockQuantity);
            DB.AddParameter("@InStock", mThisGame.InStock);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public clsStock ThisGame
        {
            get
            {
                return mThisGame;
            }
            set
            {
                mThisGame = value;
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisGame.productId);
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@Platform", mThisGame.Platform);
            DB.AddParameter("@StockQuantity", mThisGame.StockQuantity);
            DB.AddParameter("@InStock", mThisGame.InStock);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);

            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@productId", mThisGame.productId);

            DB.Execute("sproc_tblStock_Delete");
        }
    }

}
