using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class OrderItemController
    {
        #region Data Members
        private OrderItemDB orderItemDB;//make reference 
        private Collection<OrderItem> orderItems;
        private DB.DBOperation operation;
        #endregion

        #region Properties
        public Collection<OrderItem> AllOrderItem
        {
            get
            {
                return orderItems;
            }
        }
        #endregion

        #region Constructor
        public OrderItemController()
        {
            //***instantiate the ProductDB object to communicate with the database
            orderItemDB = new OrderItemDB();
            //products = productDB.AllProducts;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(OrderItem orderItem, DB.DBOperation operation) //DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            orderItemDB.DataSetChange(orderItem, operation);//calling method to do the insert

            //*** Add the employee to the Collection
            //products.Add(aProduct);


        }

        public bool FinalizeChanges(OrderItem orderItem)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return orderItemDB.UpdateDataSource(orderItem);

        }
        #endregion




    }
}
