using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class Order
    {

            #region Data Members
            //encapsulation
            private string orderId;
            private string dateCreated;
            private string shipAddress;
            private decimal grandTotal;
        private string orderItem;
            private Collection<Product> products;

        private enum status 
            {
                newOrder = 0,
                onHold = 1, 
                Shipped = 2,
                Delivered = 3,
                Closed = 4,
            }

        #endregion

            #region Property methods
        public string OrderItem { get { return orderItem; } set { orderItem = value; } }
            public string OrderId
            {
                get { return orderId; }
                set { orderId = value; }
            }
           
            public string DateCreated
             {   
                get { return dateCreated; }
                set { dateCreated = value; }

            }
            public string ShipAddress
              {
                get { return shipAddress; }
                set { shipAddress = value; }

            }
            public decimal GrandTotal
              {
                get { return grandTotal; }
                set { grandTotal = value; }
            }

            #endregion

            #region Constructor
            public Order()
            {

               
            }
            #endregion

        }
    }

















