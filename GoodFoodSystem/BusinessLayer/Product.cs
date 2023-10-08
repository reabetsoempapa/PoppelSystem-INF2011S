using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class Product
    {

            #region Data Members
            //encapsulation
            private string productId;
            private string productName;
            private string productDescription;
            private decimal productPrice;
            private string productSupplier;
            private int productStockCount;
            private string expiryDate;
            private int quantity;

            #endregion

            #region Property methods
            public string ProductId
        {
                get { return productId; }
                set { productId = value; }
            }
            public string ProductName
        {
                get { return productName; }
                set { productName = value; }

            }
            public string ProductDescription
        {
                get { return productDescription; }
                set { productDescription = value; }

            }
            public decimal ProductPrice
            {
                get { return productPrice; }
                set { productPrice = value; }
            }
            public string ProductSupplier
            {
                get { return productSupplier; }
                set { productSupplier = value; }
            }
            public int ProductStockCount
            {
                get { return productStockCount; }
                set { productStockCount = value; }
            }
            public string ExpiryDate
            {
                get { return expiryDate; }
                set { expiryDate = value; }
            }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        #endregion

            #region Constructor
        public Product()
            {
                
            }
            #endregion


    }
}

