using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Source
{
    public class Users
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal Salary { get; set; }
        public bool Select { get; set; }
        public ICollection<Expenses> ExpensesC { get; set; }
    }
}
