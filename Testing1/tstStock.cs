using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    class tstStock
    {
        public void InstanceOK()
        {
            //Creates an instance of Stock called game
            clsStock Game = new clsStock();
            //tests to see if it exists
            Assert.IsNotNull(Game);
        }
    }
}
