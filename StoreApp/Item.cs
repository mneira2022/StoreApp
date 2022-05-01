using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    /// <summary>
    /// This class represents a single product in the store
    /// </summary>
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SKU { get; set; }
    }
}
