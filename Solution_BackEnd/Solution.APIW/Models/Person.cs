using System;
using System.Collections.Generic;

#nullable disable

namespace Solution.APIW.Models
{
    public partial class Person
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string HireDate { get; set; }

        public string EnrollmentDate { get; set; }

        public string Discriminator { get; set; }
    }
}
