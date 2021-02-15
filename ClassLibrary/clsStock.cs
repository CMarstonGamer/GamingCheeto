using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        public int productId { get; set; }
        public string GameTitle { get; set; }
        public int Price { get; set; }
        public string Platform { get; set; }
        public Boolean InStock { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
