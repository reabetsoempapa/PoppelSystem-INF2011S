using GoodFoodSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace GoodFoodSystem.DatabaseLayer
{
    public class ProductDB:DB
    {

        //public Collection<Product> AllEmployees { get; internal set; }

        #region  Data members 
        private string table1 = "Expired Products";
        private string sqlLocal1 = "SELECT * FROM Expired Products";
        private string table2 = "Products";
        private string sqlLocal2 = "SELECT * FROM Products";


        private Collection<Product> products;
        #endregion


        #region Property Method: Collection
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }
        #endregion


        #region Constructor
        public ProductDB() : base()
        {
            products = new Collection<Product>();

            //FillDataSet(sqlLocal1, table1);
            // Add2Collection(table1);
              FillDataSet(sqlLocal2, table2);
             Add2Collection(table2);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string Table)
        {
            DataRow myRow = null;
            Product aProduct;


            foreach (DataRow myRow_LoopVariable in dsMain.Tables[Table].Rows)
            {
                myRow = myRow_LoopVariable;
                if(!(myRow.RowState == DataRowState.Deleted))
                {
                    aProduct = new Product();
                    aProduct.ProductId = Convert.ToString(myRow["ID"]).TrimEnd();
                    aProduct.ProductName = Convert.ToString(myRow["Name"]).TrimEnd();  
                    aProduct.ProductDescription = Convert.ToString(myRow["Description"]).TrimEnd();
                    aProduct.ProductSupplier = Convert.ToString(myRow["Supplier"]).TrimEnd();
                    aProduct.ProductPrice = Convert.ToDecimal(myRow["Price"]);
                    aProduct.ExpiryDate = Convert.ToString(myRow["ExpiryDate"]).TrimEnd();
                    aProduct.ProductStockCount = Convert.ToInt32(myRow["StockCount"]);
                    products.Add(aProduct);


                }
            }
        }
        private void FillRow(DataRow aRow, Product product, DB.DBOperation operation)
        {
            
            if (operation == DB.DBOperation.Add)
            {
                aRow["ID"] = product.ProductId;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = product.ProductName;
            aRow["Description"] = product.ProductDescription;

            aRow["Price"] = product.ProductPrice;
            aRow["Supplier"] = product.ProductSupplier;
            aRow["StockCount"] = product.ProductStockCount;
            aRow["ExpiryDate"] = product.ExpiryDate;

        }
        private int FindRow(Product product, string table)
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
                    if (product.ProductId == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }



#endregion


        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Product aProduct)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ProductID", SqlDbType.NVarChar, 15, "ProductID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Decimal, 15, "Price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StockCount", SqlDbType.NVarChar, 15, "StockCount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Supplier", SqlDbType.NVarChar, 15, "Supplier");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ExpiryDate", SqlDbType.NVarChar, 15, "ExpiryDate");
            daMain.InsertCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Product aProduct)
        {
           // conditions 
            daMain.InsertCommand = new SqlCommand("INSERT into Products (ProductID, Name, Description, Price, Supplier, StockCount, ExpiryDate) VALUES (@ProductID, @Name, @Description, @Price, @Supplier, @StockCount, @ExpiryDate)", cnMain);
         // if expirey date has passed then insert into expired products table.
            daMain.InsertCommand = new SqlCommand("INSERT into Expired Products (ProductID, Name, Description, Price, Supplier, StockCount, ExpiryDate) VALUES (@ProductID, @Name, @Description, @Price, @Supplier, @StockCount, @ExpiryDate)", cnMain);

            Build_INSERT_Parameters(aProduct);
        }

        public bool UpdateDataSource(Product aProduct)
        {
            bool success = true;
            Create_INSERT_Command(aProduct);
            //Create_UPDATE_Command(aProduct);
           // Create_DELETE_Command(aProduct);
           
            // if expired update both tables 
                    success = UpdateDataSource(sqlLocal1, table1);
            //else if not just the products table 
                    success = UpdateDataSource(sqlLocal2, table2);      
            return success;
        }


        #endregion

        #region Crud 
        public void DataSetChange( Product product, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table2;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, product, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(product, dataTable)];
                    FillRow(aRow, product, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(product, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion
    }
}
