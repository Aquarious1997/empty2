using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Class1
    {
       
        private string price;
        private string quantity;
        private string capacity;

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }
    }
}