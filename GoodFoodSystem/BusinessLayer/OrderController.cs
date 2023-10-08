using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class OrderController
    {
        #region Data Members 
        private OrderDB orderDB;
        private Collection<Order> orders;
        #endregion

        #region Properties 
        public Collection<Order> AllOrders
        {
            get
            {
                return orders;
            }
        }

        #endregion

        #region Constructor 

        public OrderController()
        {
            orderDB = new OrderDB();
            orders = orderDB.AllOrders;
        }


        #endregion

        #region Database Communication.
        public void DataMaintenance(Order aOrder, DB.DBOperation operation) //DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            orderDB.DataSetChange(aOrder, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    orders.Add(aOrder);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aOrder);
                    orders[index] = aOrder;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aOrder);
                    orders.RemoveAt(index);
                    break;


            }

        }
        //***Commit the changes to the database
        public bool FinalizeChanges(Order order)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return orderDB.UpdateDataSource(order);

        }
        #endregion

        #region Search Methods
        public int FindIndex(Order order)
        {
            int counter = 0;
            bool found = false;
            found = (order.OrderId == orders[counter].OrderId);   //using a Boolean Expression to initialise found
            while (!(found) & counter < orders.Count - 1)
            {
                counter += 1;
                found = (order.OrderId == orders[counter].OrderId);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        public Order Find(string ID)
        {
            int index = 0;
            bool found = (orders[index].OrderId == ID);  //check if it is the first record
            int count = orders.Count;
            while (!(found) && (index < orders.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (orders[index].OrderId == ID);   // this will be TRUE if found
            }
            return orders[index];  // this is the one!  
        }


    }
        #endregion




    




}
