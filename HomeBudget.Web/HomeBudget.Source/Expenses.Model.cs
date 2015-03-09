using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudget.Source
{
    public class Expenses
    {
        public int Id { get; set; }
        public decimal RentAmount { get; set; }
        public decimal WaterAmount { get; set; }
        public decimal ElectricityAmount { get; set; }
        public decimal CableAmount { get; set; }
        public decimal InternetAmount { get; set; }
        public decimal NetFlixAmount { get; set; }
        public decimal VehicleInsuranceAmount { get; set; }
        public decimal PhoneBillAmount { get; set; }
        public decimal OtherAmounts { get; set; }
    }
}
