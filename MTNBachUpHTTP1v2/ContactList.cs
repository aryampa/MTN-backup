using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTNBachUpHTTP1v2
{
    class ContactList
    {

    }

    public class jsonClass
    {
        public Boolean iserror;
        public String requestid;
        public String timestamp;
        public dataContainer data = new dataContainer();

    }

    public class dataContainer
    {
        public List<contact> contacts = new List<contact> { };
    }


    public class contact
    {
        public String firstname;
        public String middlename;
        public String lastname;
        public String mobile1;
        public String mobile2;
        public String mobile3;

    }

}
