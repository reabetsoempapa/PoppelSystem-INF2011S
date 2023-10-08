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
    public class CustomerDB : DB
    {
        #region  Data members 
        private string table1 = "Customer";
        private string sqlLocal1 = "SELECT * FROM Customer";


        private Collection<Customer> customers;
        #endregion


        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion


        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();

            FillDataSet(sqlLocal1, table1);

            Add2Collection(table1);

        }
        #endregion


        #region utitlity Methods 
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Customer aCustomer;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    aCustomer = new Customer();
                    //Obtain each employee attribute from the specific field in the row in the table
                    aCustomer.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                    //Do the same for all other attributes
                    aCustomer.CustomerId = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    aCustomer.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aCustomer.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aCustomer.CustomerAddress = Convert.ToString(myRow["Address"]).TrimEnd();
                    aCustomer.CustomerEmail = Convert.ToString(myRow["Email"]).TrimEnd();
                    aCustomer.CreditStatus = Convert.ToDecimal(myRow["CreditStatus"]);
                    customers.Add(aCustomer);


                }
            }
        }

        private void FillRow(DataRow aRow, Customer customer, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["ID"] = customer.ID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["CustomerID"] = customer.CustomerId;
            }
            aRow["Name"] = customer.Name;
            aRow["Phone"] = customer.Telephone;
            aRow["Address"] = customer.CustomerAddress;
            aRow["Email"] = customer.CustomerEmail;
            aRow["CreditStatus"] = customer.CreditStatus;
        }

        private int FindRow(Customer customer, string table)
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
                    if (customer.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
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
        public void DataSetChange(Customer customer, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, customer, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(customer, dataTable)];
                    FillRow(aRow, customer, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(customer, dataTable)];
                    aRow.Delete();
                    break;
            }
        }


        #endregion

        #region Build Parameters, Create Commands & Update database

        private void Build_INSERT_Parameters(Customer customer)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 15, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditStatus", SqlDbType.Decimal, 15, "CreditStatus");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Create_INSERT_Command(Customer customer)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into Customer (ID, CustomerID, Name, Phone, Address, Email, CreditStatus) VALUES (@ID, @CustomerID, @Name, @Phone, @Address, @Email, @CreditStatus)", cnMain);

            Build_INSERT_Parameters(customer);
        }

        private void Build_UPDATE_Parameters(Customer customer)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 100, "CustomerID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 100, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditStatus", SqlDbType.Decimal, 100, "CreditStatus");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 100, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        public bool UpdateDataSource(Customer customer)
        {
            bool success = true;
            Create_INSERT_Command(customer);
            Create_UPDATE_Command(customer);
            // Create_DELETE_Command(customer);

            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }

        private void Create_UPDATE_Command(Customer customer)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed


            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, Phone =@Phone, Address =@Address, Email = @Email, CreditStatus = @CreditStatus " + "WHERE ID = @Original_ID", cnMain);


            Build_UPDATE_Parameters(customer);
        }



        #endregion





    }
}
