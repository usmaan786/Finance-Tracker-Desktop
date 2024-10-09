﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Tracker
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; }
        public double CurrentSpending { get; private set; }
        public double Budget { get; private set; }

        public List<Spending> Spendings { get; private set; }

        public User(string name) : this(name, 0.00, 0.00) 
        {

        }

        public User(string name, double currentSpending, double budget)
        {
            Name = name;
            CurrentSpending = currentSpending;
            Budget = budget;
            Spendings = new List<Spending>();
        }

        public void UpdateBudget(double budget)
        {
            Budget = budget;
        }

        public void UpdateSpending(string item, double spent, DateTime transactionDate)
        {
            CurrentSpending += spent;
            Spending transactionDetails = new Spending(item, spent, transactionDate);
            Spendings.Add(transactionDetails);
        }

        public string DisplaySpendings()
        {
            StringBuilder results = new StringBuilder();
            foreach (var spending in Spendings )
            {
                results.Append(spending.GetInfo() + "\n");
            }

            return results.ToString();
        }
    }
}