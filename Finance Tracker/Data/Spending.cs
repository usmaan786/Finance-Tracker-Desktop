using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    public class Spending : ISpending
    {
        public string Item { get; }
        public decimal Spent { get; }
        public DateTime TransactionDate { get; }

        public Spending(string item, decimal spent, DateTime transactionDate)
        {
            Item = item;
            Spent = spent;
            TransactionDate = transactionDate;
        }

        public string GetInfo()
        {
            return $"{Item} - {Spent} | Transaction Date: {TransactionDate.ToString()}";
        }
    }
}
