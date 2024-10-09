using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    interface IUser
    {
        string Name { get; }
        decimal CurrentSpending { get; }
        decimal Budget { get; }
        List<Spending> Spendings { get; }

        void UpdateBudget(decimal budget);
        void UpdateSpending(decimal spent);
        string DisplaySpendings();
    }
}
