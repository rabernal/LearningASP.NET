using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBBudget.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal Salary { get; set; }
        public ICollection<Utility> UtilityCollection { get; set; }
    }
}