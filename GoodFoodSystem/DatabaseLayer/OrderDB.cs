using GoodFoodSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoodFoodSystem.DatabaseLayer
{
    public class OrderDB : DB
    {

        #region  Data members 
        //private string table1 = "Picking_List";
        //private string sqlLocal1 = "SELECT * FROM Picking_List"; //Not sure of the logic behind this
        private string table2 = "[Order]";
        private string sqlLocal2 = "SELECT * FROM [Order]";
        private Collection<Order> orders;
        #endregion


        #region Property Method: Collection
        public Collection<Order> AllOrders
        {
            get
            {
                return orders;
            }
        }
        #endregion

        #region Constructor
        public OrderDB() : base()
        {
            orders = new Collection<Order>();

            //FillDataSet(sqlLocal1, table1);
            //Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            //Add2Collection(table2);


        }
        #endregion

        #region Utility Methods 

        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Order order;


            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    order = new Order();
                    //Obtain each employee attribute from the specific field in the row in the table
                    order.OrderId = Convert.ToString(myRow["ID"]).TrimEnd();
                    //Do the same for all other attributes
                    order.DateCreated = Convert.ToString(myRow["DateCreated"]).TrimEnd();
                    order.ShipAddress = Convert.ToString(myRow["Address"]).TrimEnd();
                    order.GrandTotal = Convert.ToDecimal(myRow["OrderTotal"]);
                    orders.Add(order);

                }
            }
        }
        private void FillRow(DataRow aRow, Order order, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["ID"] = order.OrderId;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["DateCreated"] = order.DateCreated;
            aRow["Address"] = order.ShipAddress;
            aRow["OrderTotal"] = order.GrandTotal;

            //*** For each role add the specific data variables

        }
        private int FindRow(Order order, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it 
                    //is automatically known to the compiler when used as below
                    if (order.OrderId == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations Crud

        public void DataSetChange(Order order , DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table2;
            
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, order, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(order, dataTable)];
                    FillRow(aRow, order, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(order, dataTable)];
                    aRow.Delete();
                    break;
            }
        }

        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Order anOrder)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size

            param = new SqlParameter("@DateCreated", SqlDbType.NVarChar, 15, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@OrderTotal", SqlDbType.Decimal, 15, "OrderTotal");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@OrderItems", SqlDbType.NVarChar, 15, "OrderItems");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Order anOrder)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into [Order] (ID, DateCreated, Address, OrderTotal, OrderItems) VALUES (@ID, @DateCreated, @Address, @OrderTotal, @OrderItems)", cnMain);

            Build_INSERT_Parameters(anOrder);
        }

        public bool UpdateDataSource(Order anOrder)
        {
            bool success = true;
            Create_INSERT_Command(anOrder);
            //Create_UPDATE_Command(anOrder);
            // Create_DELETE_Command(anOrder);

            success = UpdateDataSource(sqlLocal2, table2);

            return success;
        }
        #endregion

    }
}
