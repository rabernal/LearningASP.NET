using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyExpenses
{
    public interface IHomeExpenceDataSource
    {
        IQueryable<HomeMonthlyExpenses> HomeExpenses { get; }
    }
}
