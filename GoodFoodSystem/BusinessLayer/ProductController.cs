using GoodFoodSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class ProductController
    {
            #region Data Members
            private ProductDB productDB;//make reference 
            private Collection<Product> products;
            private DB.DBOperation operation;
        #endregion

            #region Properties
        public Collection<Product> AllProducts
            {
                get
                {
                    return products;
                }
            }
            #endregion

            #region Constructor
            public ProductController()
            {
                //***instantiate the ProductDB object to communicate with the database
                productDB = new ProductDB();
                products = productDB.AllProducts;
            }
            #endregion

            #region Database Communication.
            public void DataMaintenance(Product aProduct, DB.DBOperation operation) //DB.DBOperation operation)
            {
                int index = 0;
            //perform a given database operation to the dataset in meory; 
            productDB.DataSetChange(aProduct, operation);//calling method to do the insert

            //*** Add the employee to the Collection
              products.Add(aProduct);
                      

             }
            

            //***Commit the changes to the database
            public bool FinalizeChanges(Product aProduct)
            {
                //***call the EmployeeDB method that will commit the changes to the database
                return productDB.UpdateDataSource(aProduct);

            }
            #endregion

            #region Search Methods
            //This method  (function) searched through all the employess to finds onlly those with the required role

            public Product Find(string ID)
            {
                int index = 0;
                bool found = (products[index].ProductId == ID);  //check if it is the first record
                int count = products.Count;
                while (!(found) && (index < products.Count - 1))  //if not "this" record and you are not at the end of the list 
                {
                    index = index + 1;
                    found = (products[index].ProductId == ID);   // this will be TRUE if found
                }
                return products[index];  // this is the one!  
            }

            public int FindIndex(Product aProduct)
            {
                int counter = 0;
                bool found = false;
                found = (aProduct.ProductId == products[counter].ProductId);   //using a Boolean Expression to initialise found
                while (!(found) & counter < products.Count - 1)
                {
                    counter += 1;
                    found = (aProduct.ProductId == products[counter].ProductId);
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









