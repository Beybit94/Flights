using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class CustomerModel:Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Taxnumber { get; set; }

        public string FullName
        {
            get
            {
                return string.Concat(FirstName, " ", LastName);
            }
        }
        public DateTime BirthDate { get; set; }
    }
}
