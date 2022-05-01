using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    /// <summary>
    /// This is the user account that stores customer information and transaction history
    /// </summary>
    class CustomerAccount
    {
        private static int lastCustomerNumber = 0;
        #region Properties
        public int CustomerNumber { get; private set; }
        public string UserName { get; set; }
        public string  CustomerName { get; set; }
        
        public string EmailAddress { get; set; }
        
        #endregion

        #region Constructor
        public CustomerAccount()
        {
 
            CustomerNumber = lastCustomerNumber++;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds an order to customer's order history
        /// </summary>
        /// <param name="OrderNumber">The order number of order to be added</param>
        public void AddOrderToHistory(int OrderNumber) { }
        #endregion
    }
}
