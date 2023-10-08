using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodFoodSystem.DatabaseLayer;

namespace GoodFoodSystem.BusinessLayer
{
    public class CustomerController
    {
        #region Data Members
        private  CustomerDB customerDB;//make reference 
        private Collection<Customer> customers;
        #endregion

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            //***instantiate the customerDB object to communicate with the database
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Customer aCustomer, DB.DBOperation operation)
        {
            //perform a given database operation to the dataset in meory; 
            customerDB.DataSetChange(aCustomer,operation);//calling method to do the insert

                   customers.Add(aCustomer);

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return customerDB.UpdateDataSource(customer);

        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role

        public Collection<Customer> FindByID(Collection<Customer> customers, Customer Customer)
        {
            Collection<Customer> matches = new Collection<Customer>();

            foreach (Customer cust in customers)
                ///check if the customer id is in the collection of customers, if it is login if it isnt create new customer and add it 
            {
                if (cust.CustomerId == cust.CustomerId)
                {
                    matches.Add(cust);
                }
            }
            return matches;
        }



        public Customer Find(string ID)
        {
            int index = 0;
            bool found = (customers[index].ID == ID);  //check if it is the first record
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].ID == ID);   // this will be TRUE if found
            }
            return customers[index];  // this is the one!  
        }

        public int FindIndex(Customer aCustomer)
        {
            int counter = 0;
            bool found = false;
            found = (aCustomer.ID == customers[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCustomer.ID == customers[counter].ID);
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
        #endregion
    }
}
