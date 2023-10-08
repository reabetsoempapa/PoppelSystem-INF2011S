using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class OrderItem
    {
        #region Data Memembers 
        String id;
        String itemName;
        String orderID;
        int price;
        int quantity;

        #endregion

        #region Property Methods
        public string ID { get { return id; } set { id = value; } }
        public string OrderID { get { return orderID; } set { orderID = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public String ItemName { get { return itemName; } set { itemName = value; } }

        #endregion

        #region Constructor 


        #endregion

        #region

        #endregion
    }
}
