using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.Common.dll;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using GoodFoodSystem.BusinessLayer;


namespace GoodFoodSystem.DatabaseLayer
{
    public class OrderItemDB:DB
    {
        private string table1 = "[Order]";
        private string sqlLocal1 = "SELECT * FROM OrderItem ";
        //private Collection<Order> orders
        //


        #region Constructor

        public OrderItemDB() : base()
        {
            //orders = new Collection<Order>();

            //FillDataSet(sqlLocal1, table1);
            //Add2Collection(table1);
            FillDataSet(sqlLocal1, table1);
            //Add2Collection(table2);


        }

        #endregion

        #region utility Methods
        private void FillRow(DataRow aRow, OrderItem orderItem, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["ID"] = DBNull.Value;
                //String id = orderItem.ID;
                //if(id != null)
                //{
                //    aRow["ID"] = orderItem.ID;

                //}
                //else
                //{
                //    aRow["ID"] = DBNull.Value;
                //}

                //dt.Columns[0].AllowDBNull = True;//NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["orderID"] = orderItem.OrderID;
            
            aRow["ItemName"] = orderItem.ItemName;
            aRow["Price"] = orderItem.Price;
            aRow["Quantity"] = orderItem.Quantity;


            //*** For each role add the specific data variables

        }
        private int FindRow(OrderItem orderItem, string table)
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
                    if (orderItem.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
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

        public void DataSetChange(OrderItem orderItem, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, orderItem, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(orderItem, dataTable)];
                    FillRow(aRow, orderItem, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(orderItem, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(OrderItem anOrderItem)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter param = default(SqlParameter);

            //param = new SqlParameter("@ID", SqlDbType.Int, 15, "ID");
            //daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size

            param = new SqlParameter("@orderID", SqlDbType.NVarChar, 15, "orderID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ItemName", SqlDbType.NVarChar, 15, "ItemName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Decimal, 15, "Price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Quantity", SqlDbType.NVarChar, 15, "Quantity");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(OrderItem anOrderItem)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into OrderItem (orderID, ItemName, Price, Quantity) VALUES (@orderID, @ItemName, @Price, @Quantity)", cnMain);

            Build_INSERT_Parameters(anOrderItem);
        }


        public bool UpdateDataSource(OrderItem anOrderItem)
        {
            bool success = true;
            Create_INSERT_Command(anOrderItem);
            //Create_UPDATE_Command(anOrder);
            // Create_DELETE_Command(anOrder);

            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }
        #endregion

    }
}
