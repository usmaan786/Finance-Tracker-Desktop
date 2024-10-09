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
        public string LoadUserData()
        {
            using (var context = new FinanceContext())
            {
                _currentUser = context.Users
                    .Include(u => u.Spendings)
                    .FirstOrDefault();

                if (_currentUser != null)
                {
                    return _currentUser.Name;
                }
                else
                {
                    MessageBox.Show("No Users Found");
                }
            }
            return "";
        }
    }
}
