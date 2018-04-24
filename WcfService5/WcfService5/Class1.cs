using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService5
{
    public class Class1
    {
        private string name;
        private string password;
        private string email;
        private string secretQ;
        private string secretA;
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string SecretQ
        {
            get
            {
                return secretQ;
            }

            set
            {
                secretQ = value;
            }
        }

        public string SecretA
        {
            get
            {
                return secretA;
            }

            set
            {
                secretA = value;
            }
        }

       
    }
}