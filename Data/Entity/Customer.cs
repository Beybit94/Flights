using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class Customer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Taxnumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
