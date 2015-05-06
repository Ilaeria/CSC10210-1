using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1
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

            //Check required last name is not null
            if (lastName == "")
            {
                lastName = "**error**";
            }

            //Check one of email OR phone is not null
            if (phoneNumber == 0)
            {
                if (emailAddress == "")
                {
                    emailAddress = "**error**";
                }
            }
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
                
                //Last name can't be empty
                if (lastName == "")
                {
                    lastName = "**error**";
                }
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

                //Must be at least one of phone number/email address
                if (phoneNumber == 0)
                {
                    if (emailAddress == "")
                    {
                        emailAddress = "**error**";
                    }
                }
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

                //Must be at least one of phone number/email address
                if (emailAddress == "")
                {
                    if (phoneNumber == 0)
                    {
                        emailAddress = "**error**";
                    }
                }
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
