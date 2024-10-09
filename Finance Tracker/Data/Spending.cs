using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    public class Spending : ISpending
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public double Spent { get; set; }
        public DateTime TransactionDate { get; set; }

        public int UserId { get; set; }

        public Spending() { }
        public Spending(string item, double spent, DateTime transactionDate)
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
