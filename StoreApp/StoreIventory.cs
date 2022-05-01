using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    /// <summary>
    /// This class is for managing the store's iventory
    /// </summary>
    class StoreIventory
    {
        #region Methods
        /// <summary>
        /// This method will add an item to the inventory
        /// </summary>
        public void AddItem() { }
        /// <summary>
        /// This method will remove an item from the inventory
        /// </summary>
        public void RemoveItem() { }
        /// <summary>
        /// Returns the number of the given item in stock
        /// </summary>
        /// <param name="SKU">The SKU of the item to get the stock of</param>
        /// <returns>The stock of the given item</returns>
        public int GetItemStock(string SKU)
        { 
            // TODO Return actual stock
            return 1;
        }
        #endregion
    }
}
