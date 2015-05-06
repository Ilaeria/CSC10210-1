using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part3
{
    //Handle various formatting exceptions with the Contact class
    public class ContactException : Exception
    {
        public int code = 0;
        public string error = "";
        
        //default constructor
        public ContactException()
            : base("Your contact record is not in the correct format.")
        {

        }

        //constructor with error message
        public ContactException(int errorCode, string errorMessage) 
            : base(errorMessage)
        {
            this.code = errorCode;
            this.error = errorMessage;
        }
    }
}
