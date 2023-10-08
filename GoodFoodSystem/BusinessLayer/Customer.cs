using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodSystem.BusinessLayer
{
    public class Customer:Person
    {


        #region Data Members
        //encapsulation
        private string customerId;
        private string customerAddress;
        private string customerTelephone;
        private string customerEmail;
        private decimal creditStatus;
        private decimal customerDebt;
        #endregion

        #region Property methods
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }

        }
         public string CustomerTelephone
        {
            get { return customerTelephone; }
            set { customerTelephone = value; }

        }
          public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }
        public Decimal CreditStatus
        { 
            get { return creditStatus; }
            set { creditStatus = value; }
        }  
                  
        #endregion

        #region Constructor
        public Customer() { }
        public Customer(String customerId)
        {

        }
        #endregion

    }
}
