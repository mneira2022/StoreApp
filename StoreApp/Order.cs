using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    /// <summary>
    /// This is where I manage a customer's order
    /// </summary>
    class Order
    {
        private static int lastOrderNumber = 0;
        #region Properties
        public int OrderNumber { get; set; }
        public int TotalItems { get; private set; }
        public DateTime OrderDate { get; set; }
        public int CustomerNumber { get; set; }
        #endregion

        #region Constructor
        public Order()
        {
            OrderNumber = lastOrderNumber++;
        }
        #endregion
    }
}
