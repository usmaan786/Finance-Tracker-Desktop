using Finance_Tracker.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Finance_Tracker
{
    public class LoadDB
    {
        private User _currentUser;
        public string LoadUser(string option)
        {
            using (var context = new FinanceContext())
            {
                _currentUser = context.Users
                    .Include(u => u.Spendings)
                    .FirstOrDefault();

                if (_currentUser != null && option == "name")
                {
                    return _currentUser.Name.ToString();
                }
                else if (_currentUser != null && option == "current spending")
                {
                    return _currentUser.CurrentSpending.ToString();
                }
                else if (_currentUser != null && option == "budget")
                {
                    return _currentUser.Budget.ToString();
                }
                else
                {
                    MessageBox.Show("No Users Found");
                }
            }
            return "";
        }

        public string LoadUserData()
        {
            using (var context = new FinanceContext())
            {
                _currentUser = context.Users
                    .Include(u => u.Spendings)
                    .FirstOrDefault();

                if (_currentUser != null)
                {
                    return _currentUser.DisplaySpendings();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            return "";
        }

        public void UpdateUserBudget(double budget)
        {
            using (var context = new FinanceContext())
            {
                _currentUser = context.Users.FirstOrDefault();

                if( _currentUser != null )
                {
                    _currentUser.UpdateBudget(budget);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }

        public void AddUserSpending(string item, double amount, DateTime transactionDate)
        {
            using (var context = new FinanceContext())
            {
                _currentUser = context.Users.FirstOrDefault();

                if( _currentUser != null )
                {
                    _currentUser.UpdateSpending(item, amount, transactionDate);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
