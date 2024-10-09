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
        double CurrentSpending { get; }
        double Budget { get; }
        List<Spending> Spendings { get; }

        void UpdateBudget(double budget);
        void UpdateSpending(string item, double spent, DateTime transactionDate);
        string DisplaySpendings();
    }
}
