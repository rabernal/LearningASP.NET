using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBBudget.DataSource
{
    public interface IUsersBudgetData
    {
        IQueryable<UserBudget> UsersBudget { get; }
    }
}
