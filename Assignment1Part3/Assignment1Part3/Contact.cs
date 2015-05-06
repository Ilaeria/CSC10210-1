using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part3
{
    //Create a contact record that must include a last name 
    //and at least one of phone number and/or email address.
    public class Contact
    {
        private string lastName;
        private string otherNames;
        private string companyName;
        private long phoneNumber;
        private string emailAddress;

        //Constructor
        public Contact(string last, string other, string company,
            long phone, string email)
        {
            lastName = last;
            otherNames = other;
            companyName = company;
            phoneNumber = phone;
            emailAddress = email;
        }

        //Setters and getters
        public string last
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string other
        {
            get
            {
                return otherNames;
            }
            set
            {
                otherNames = value;
            }
        }

        public string company
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        public long phone
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public string email
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }

        //Return record fields
        public void GetRecord()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                lastName, otherNames, companyName, phoneNumber, emailAddress);
        }

        //Display formatted contact card
        public void PrintRecord()
        {
            Console.WriteLine("Last Name:     {0}", lastName);
            Console.WriteLine("Other Names:   {0}", otherNames);
            Console.WriteLine("Company Name:  {0}", companyName);
            Console.WriteLine("Phone Number:  {0}", phoneNumber);
            Console.WriteLine("Email Address: {0}", emailAddress);
        }
    }
}
