using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }

        private string _lastName;
        
        public string LastName
        {
            get
            {
                //Any code here
                return _lastName;
            }
            set
            {
                //Any code here
                _lastName = value;
            }
        }
        public string FirstName { get; set; }

        public string EamilAddress { get; set; }

        public int CustomerId { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
       
        public Customer Retrieve(int customerId)
        {
            //code that retrieves the defined customer
            return new Customer();
        }


        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EamilAddress)) isValid = false;

            return isValid;
        }
    }
}
