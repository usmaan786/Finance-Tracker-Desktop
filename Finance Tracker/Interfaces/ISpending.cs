using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    interface ISpending
    {
        string Item { get; }
        double Spent { get; }

        DateTime TransactionDate { get; }

        string GetInfo();
    }
}
